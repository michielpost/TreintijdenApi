using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestEase;
using System;

namespace TreintijdenApi
{
    public static class TreintijdenMLabClient
    {
        private const string nsBaseUrl = "https://ns-api.nl";
        public static IMLabApi GetClient(string apiKey, string baseUrl = nsBaseUrl)
        {
            var treinApi = new RestClient(baseUrl)
            {
                JsonSerializerSettings = new JsonSerializerSettings()
                {
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                    NullValueHandling = NullValueHandling.Ignore
                }
            }.For<IMLabApi>();

            treinApi.ApiKey = apiKey;

            return treinApi;
        }
    }
}
