using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using System;

namespace TreintijdenApi
{
    public static class TreintijdenClient
    {
        private const string nsBaseUrl = "https://gateway.apiportal.ns.nl";
        public static ITreinApi GetClient(string apiKey, string baseUrl = nsBaseUrl)
        {
            var treinApi = new RestClient(baseUrl)
            {
                JsonSerializerSettings = new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                }
            }.For<ITreinApi>();

            treinApi.ApiKey = apiKey;

            return treinApi;
        }
    }
}
