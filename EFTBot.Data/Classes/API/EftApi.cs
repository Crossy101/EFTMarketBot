using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using EFTBot.Data.Models.RequestModels;
using EFTBot.Models.EFT.RequestModels.Login;
using EFTBot.Models.EFT.RequestModels.Login.Authentication;
using EFTBot.Models.EFT.RequestModels.Login.Version;
using RestSharp;

namespace EFTBot.Data.Classes.API
{
    public class EftApi
    {
        #region EFT_GAME_URLS
        private const string LAUNCHER_ENDPOINT = "https://launcher.escapefromtarkov.com";

        private string LuncherVersionEndPoint => $"{LAUNCHER_ENDPOINT}/launcher/GetLauncherDistrib?launcherVersion={_launcherVersion}";
        private string GameVersionEndPoint => $"{LAUNCHER_ENDPOINT}/launcher/GetPatchList?launcherVersion={_launcherVersion}&branch=live";
        private string LoginEndPoint => $"{LAUNCHER_ENDPOINT}/launcher/login?launcherVersion={_launcherVersion}&branch=live";
        private string AuthoriseAccountEndPoint => $"{LAUNCHER_ENDPOINT}/launcher/game/start?launcherVersion={_launcherVersion}&branch=live";
        private string ActivateHardwareEndPoint => $"{LAUNCHER_ENDPOINT}/launcher/hardwareCode/activate?launcherVersion={_launcherVersion}";
        #endregion

        private string _launcherVersion;
        private readonly string _unityVersion;
        private string _gameVersion;

        public long RequestCount => EftApiRequest.RequestCount;

        public EftApi()
        {
            //Now and then update this so it looks like a recently outdated launcher was used.
            _launcherVersion = "0.9.3.1023";

            _unityVersion = "0.12.3.5985";
            _gameVersion = "2018.4.13f1";
        }

        private List<WebHeader> GetGameRequestHeaders(string sessionCookie)
        {
            return new List<WebHeader>
            {
                new WebHeader { HeaderKey = "User-Agent", HeaderValue = $"UnityPlayer/{LinkManager.UNITY_VERSION} (UnityWebRequest/1.0, libcurl/7.52.0-DEV)" },
                new WebHeader { HeaderKey = "App-Version", HeaderValue = $"EFT Client {LinkManager.GAME_VERSION}" },
                new WebHeader { HeaderKey = "X-Unity-Version", HeaderValue = LinkManager.UNITY_VERSION },
                new WebHeader { HeaderKey = "Cookie", HeaderValue = $"PHPSESSID={sessionCookie}" }
            };
        }

        public LauncherVersionResponse GetLauncherVersion()
        {
            var headers = new List<WebHeader>()
            {
                new WebHeader("User-Agent", $"BSG Launcher {_launcherVersion}")
            };

            var req = new EftApiRequest(LuncherVersionEndPoint, headers);
            var response = req.Get<LauncherVersionResponse>();

            _launcherVersion = response.Data.data.Version;

            return response.Data;
        }

        public GameVersionResponse GetGameVersion(LoginResponse loginResponse, string sessionCookie)
        {
            var headers = new List<WebHeader>
            {
                new WebHeader ("User-Agent", $"BSG Launcher {_launcherVersion}"),
                new WebHeader ("Authorization", loginResponse.data.access_token),
                new WebHeader ("Host", "launcher.escapefromtarkov.com"),
                new WebHeader ("Cookie", $"PHPSESSID={sessionCookie}")
            };

            var req = new EftApiRequest(GameVersionEndPoint, headers);
            var response = req.Get<GameVersionResponse>();
            return response.Data;
        }

        #region Auth
        public LoginResponse CreateLoginRequest(LoginRequest loginDetails)
        {
            var headers = new List<WebHeader>
            {
                new WebHeader { HeaderKey = "User-Agent", HeaderValue = $"BSG Launcher {_launcherVersion}"}
            };

            var req = new EftApiRequest(LoginEndPoint, headers);
            var response = req.Post<LoginResponse>(loginDetails);
            return response.Data;
        }

        public AuthReponse CreateLoginAuthRequest(LoginResponse loginResponse, string hardwareId)
        {
            var headers = new List<WebHeader>
            {
                new WebHeader { HeaderKey = "User-Agent", HeaderValue = $"BSG Launcher {_launcherVersion}" },
                new WebHeader { HeaderKey = "Authorization", HeaderValue = loginResponse.data.access_token }
            };

            var req = new EftApiRequest(AuthoriseAccountEndPoint, headers);
            var authToken = new AuthToken(hardwareId, LinkManager.GAME_VERSION);
            var response = req.Post<AuthReponse>(authToken);
            return response.Data;
        }
        #endregion
    }
}
