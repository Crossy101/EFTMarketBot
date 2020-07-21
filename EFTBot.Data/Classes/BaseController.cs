using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using EFTBot.Data.Models.API;

namespace EFTBot.Data.Classes
{
    public class BaseController
    {
        protected string _sessionCookie;

        public void SetCookie(string cookie)
        {
            _sessionCookie = cookie;
        }

        protected bool CanProcess<T>(GenericResult<T> result) => result.Error == null;

        protected void Log(string msg)
        {
            string output = $"[{DateTime.Now}]: {msg}";
            Console.WriteLine(output);
            Debug.WriteLine(output);
        }
    }
}
