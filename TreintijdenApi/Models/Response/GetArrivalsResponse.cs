using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.Response
{
    public class GetArrivalsResponse
    {
        [JsonProperty("payload")]
        public ArrivalPayload Arrivals { get; set; }
    }

    public class ArrivalPayload
    {
        public List<Arrival> Arrivals { get; set; }
    }

    public class Arrival
    {
        public string Origin { get; set; }
        public string Name { get; set; }
        public string PlannedTrack { get; set; }
        public string ActualTrack { get; set; }
        public Product Product { get; set; }
        public string TrainCategory { get; set; }
        public bool Cancelled { get; set; }
        public DateTimeOffset PlannedDateTime { get; set; }
        public int PlannedTimeZoneOffset { get; set; }
        public DateTimeOffset ActualDateTime { get; set; }
        public int ActualTimeZoneOffset { get; set; }
        public List<ArrivalMessage> Messages { get; set; }
    }

   

    public class ArrivalMessage
    {
        public string Message { get; set; }
        public string Style { get; set; }
    }

}
