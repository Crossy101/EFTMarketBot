using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace EFTBot.Data.Models.API
{
    public class ApiResponse<T>
    {
        public IRestResponse Response { get; set; }
        public T Data { get; set; }
    }
}
