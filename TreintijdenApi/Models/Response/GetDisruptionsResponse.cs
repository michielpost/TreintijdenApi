using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.Response
{
    public class GetDisruptionsResponse
    {
        [JsonProperty("payload")]
        public List<Disruption> Disruptions { get; set; }
    }


}
