using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using EFTBot.Data.Models.API;
using EFTBot.Data.Models.RequestModels;
using EFTBot.Models.EFT.Enums.Trading.Traders;
using EFTBot.Models.EFT.RequestModels;
using EFTBot.Models.EFT.RequestModels.Login;
using EFTBot.Models.EFT.RequestModels.Login.Authentication;
using EFTBot.Models.EFT.RequestModels.Login.Version;
using Ionic.Zlib;
using Newtonsoft.Json;

namespace EFTBot.Data.Classes.API.Old
{
    public class EFTWebRequest
    {
        #region EFT_GAME_URLS
        private const string LAUNCHER_ENDPOINT = "https://launcher.escapefromtarkov.com";
        #endregion

        private readonly string _launcherVersionEndPoint = $"{LAUNCHER_ENDPOINT}/launcher/GetLauncherDistrib?launcherVersion={LinkManager.LAUNCHER_VERSION}";
        private readonly string _gameVersionEndPoint = $"{LAUNCHER_ENDPOINT}/launcher/GetPatchList?launcherVersion={LinkManager.LAUNCHER_VERSION}&branch=live";
        private readonly string _loginEndPoint = $"{LAUNCHER_ENDPOINT}/launcher/login?launcherVersion={LinkManager.LAUNCHER_VERSION}&branch=live";
        private readonly string _authoriseAccountEndPoint = $"{LAUNCHER_ENDPOINT}/launcher/game/start?launcherVersion={LinkManager.LAUNCHER_VERSION}&branch=live";
        private readonly string _activateHardwareEndPoint = $"{LAUNCHER_ENDPOINT}/launcher/hardwareCode/activate?launcherVersion={LinkManager.LAUNCHER_VERSION}";


        private string _sessionCookie = "";
        public static string HardwareId { get; set; }

        private string _webUrl;
        private List<WebHeader> _webHeaders;
        private object _webBody;
        private Action<string> _log;

        public EFTWebRequest(Action<string> log)
        {
            _log = log;
        }

        public EFTWebRequest(Action<string> log, string sessionCookie)
        {
            _log = log;
            _sessionCookie = sessionCookie;
        }

        public GameVersionResponse GetGameVersion(LoginResponse loginResponse)
        {
            _webUrl = _gameVersionEndPoint;
            _webHeaders = new List<WebHeader>
            {
                new WebHeader { HeaderKey = "User-Agent", HeaderValue = $"BSG Launcher {LinkManager.LAUNCHER_VERSION}" } ,
                new WebHeader { HeaderKey = "Authorization", HeaderValue = loginResponse.data.access_token } ,
                new WebHeader { HeaderKey = "Host", HeaderValue = "launcher.escapefromtarkov.com" } ,
                new WebHeader { HeaderKey = "Cookie", HeaderValue = $"PHPSESSID={_sessionCookie}" } 

            };
            _webBody = "";
            return EftPostRequest<GameVersionResponse>().Result.Data;
        }

        public GenericResult<T> EftGameRequest<T>(GameRequest request)
        {
            LinkManager.RequestsSents++;
            try
            {
                if (request == null)
                    return default;

                _webUrl = request.URL;
                _webHeaders = GetGameRequestHeaders();
                _webBody = request.body;
                return EftPostRequest<T>().Result;
            }
            catch(Exception ex)
            {
                _log($"Problem when dealing with EFT request of type {typeof(T)} - {ex}");
                return default;
            }
        }

        //public TraderDetails GetTrader(EFTTrader trader)
        //{
        //    var gr = new GameRequest(LinkManager._getTradersEndPoint, new object());
        //    TradersListResponse tlr = EftGameRequest<TradersListResponse>(gr);
        //    return tlr.data[(int)trader];
        //}

        //GET THE DEFAULT GAME HEADERS
        public List<WebHeader> GetGameRequestHeaders()
        {
            return new List<WebHeader>
            {
                new WebHeader { HeaderKey = "User-Agent", HeaderValue = $"UnityPlayer/{LinkManager.UNITY_VERSION} (UnityWebRequest/1.0, libcurl/7.52.0-DEV)" },
                new WebHeader { HeaderKey = "App-Version", HeaderValue = $"EFT Client {LinkManager.GAME_VERSION}" },
                new WebHeader { HeaderKey = "X-Unity-Version", HeaderValue = LinkManager.UNITY_VERSION },
                new WebHeader { HeaderKey = "Cookie", HeaderValue = $"PHPSESSID={_sessionCookie}" }
            };
        }

        public async Task<GenericResult<T>> EftPostRequest<T>()
        {
            var result = new GenericResult<T>();
            string currentRequestResponse = "JSON Unavailable :(";
            try
            {
                using (var client = new HttpClient())
                {
                    var httpContent = new StringContent(JsonConvert.SerializeObject(_webBody), Encoding.UTF8, "application/json");

                    foreach (WebHeader header in _webHeaders)
                    {
                        client.DefaultRequestHeaders.Add(header.HeaderKey, header.HeaderValue);
                    }

                    var response = await client.PostAsync(_webUrl, httpContent);

                    byte[] httpResponse = await response.Content.ReadAsByteArrayAsync();
                    currentRequestResponse = ZlibStream.UncompressString(httpResponse);
                    result.Data = JsonConvert.DeserializeObject<T>(currentRequestResponse);
                    return result;
                }
            }
            catch (Exception ex)
            {
                if (ex is JsonSerializationException)
                {
                    try
                    {
                        //TODO: Wrapper around T which exposes the generic error.
                        var errorObj = JsonConvert.DeserializeObject<GenericError>(currentRequestResponse);
                        _log($"Request type: {typeof(T)}, Error Code: {errorObj.Error}, Message: {errorObj.ErrorMessage}");
                        result.Error = errorObj;
                        return result;
                    }
                    catch (JsonSerializationException)
                    {

                    }
                }

                _log($"Request type: {typeof(T)}, JSON: {currentRequestResponse}, Error: {ex}");
                result.Error = new GenericError() {
                    ErrorMessage = ex.ToString()
                };
                return result;
            }
        }
    }
}
