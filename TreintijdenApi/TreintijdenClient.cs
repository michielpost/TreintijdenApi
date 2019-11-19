using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using System;

namespace TreintijdenApi
{
    public static class TreintijdenClient<T> where T : IBaseNsApi
    {
        private const string nsBaseUrl = "https://gateway.apiportal.ns.nl";
        public static T GetClient(string apiKey, string baseUrl = nsBaseUrl)
        {
            var treinApi = new RestClient(baseUrl)
            {
                JsonSerializerSettings = new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                }
            }.For<T>();

            treinApi.ApiKey = apiKey;

            return treinApi;
        }
    }
}
