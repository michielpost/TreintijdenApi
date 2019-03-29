using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.Response
{
    public class GetDisruptionResponse
    {
        [JsonProperty("payload")]
        public Disruption Disruption { get; set; }
    }
}
