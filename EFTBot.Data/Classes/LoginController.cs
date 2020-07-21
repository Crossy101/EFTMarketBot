using System.Linq;
using System.Threading;
using EFTBot.Data.Classes.API;
using EFTBot.Data.Classes.API.Old;
using EFTBot.Data.Models.Configuration;
using EFTBot.Models.EFT.RequestModels;
using EFTBot.Models.EFT.RequestModels.Login;
using EFTBot.Models.EFT.RequestModels.Login.Authentication;

namespace EFTBot.Data.Classes
{
    public class LoginController : BaseController
    {
        public LoginResponse _loginResponse;
        public AuthReponse _authResponse;
        private readonly EftApi _api;

        private readonly StartupSettings _config;
        public LoginController(StartupSettings config, EftApi api)
        {
            _config = config;
            _api = api;
        }

        public void AuthenticateLogin()
        {
            GetLatestLauncherVersion();

            EFTWebRequest.HardwareId = _config.HardwareId;
            var loginDetails = new LoginRequest
            {
                email = _config.Email,
                pass = _config.Password,
                hwCode = EFTWebRequest.HardwareId,
                captcha = null
            };

            var gameWebRequest = new EFTWebRequest(Log);
            _loginResponse = _api.CreateLoginRequest(loginDetails);
            _authResponse = _api.CreateLoginAuthRequest(_loginResponse, _config.HardwareId);

            int authResponseCode = (int)_authResponse?.err;
            if (authResponseCode > 0)
            {
                Log($"Received error {authResponseCode} - {_authResponse.errmsg}... Unable to continue.");
            }

            GetLatestGameVersion();
        }

        private void GetLatestLauncherVersion()
        {
            while (LinkManager.LAUNCHER_VERSION == null)
            {
                var versionResponse = _api.GetLauncherVersion();
                if (versionResponse != null)
                {
                    LinkManager.LAUNCHER_VERSION = versionResponse.data.Version;
                    break;
                }

                Thread.Sleep(500);
            }
        }

        private void GetLatestGameVersion()
        {
            while (LinkManager.GAME_VERSION == null)
            {
                var versionResponse = _api.GetGameVersion(_loginResponse, _authResponse.data.session);
                if (versionResponse != null)
                {
                    LinkManager.GAME_VERSION = versionResponse.data.First().Version;
                    break;
                }

                Thread.Sleep(500);
            }
        }
    }
}