using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;
using EFTBot.Data.Models.API;
using EFTBot.Data.Models.RequestModels;
using EFTBot.Models.EFT.RequestModels;
using Ionic.Zlib;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Serialization.Json;

namespace EFTBot.Data.Classes.API
{
    public class EftApiRequest
    {
        private readonly string _endpoint;
        private readonly List<WebHeader> _headers;

        private static long _requestCount;
        public static long RequestCount
        {
            get => Volatile.Read(ref _requestCount);
            private set => Volatile.Write(ref _requestCount, value);
        }

        public EftApiRequest(string endpoint, List<WebHeader> headers)
        {
            _endpoint = endpoint;
            _headers = headers;
        }

        public EftApiRequest(string endpoint) : this(endpoint, new List<WebHeader>())
        {

        }

        private ApiResponse<T> Execute<T>(RestClient client, RestRequest request)
        {

            foreach (var header in _headers)
            {
                request.AddHeader(header.HeaderKey, header.HeaderValue);
            }

            var restResponse = client.Execute<T>(request);
            var resp = new ApiResponse<T>
            {
                Response = restResponse
            };

            if (resp.Response.StatusCode == HttpStatusCode.OK)
            {
                var decompressedData = ZlibStream.UncompressString(restResponse.RawBytes);
                resp.Data = JsonConvert.DeserializeObject<T>(decompressedData);
            }

            RequestCount++;
            return resp;
        }

        public ApiResponse<T> Get<T>()
        {
            var client = new RestClient(_endpoint);
            var request = new RestRequest(Method.GET);
            return Execute<T>(client, request);
        }

        public ApiResponse<T> Post<T>(object data)
        {
            var client = new RestClient(_endpoint);
            var request = new RestRequest(Method.POST);
            var serializedObj = JsonConvert.SerializeObject(data);
            request.AddParameter("application/json; charset=utf-8", serializedObj, ParameterType.RequestBody);
            request.RequestFormat = DataFormat.Json;
            return Execute<T>(client, request);
        }
    }
}
