using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.Response
{
    public class GetDeparturesResponse
    {
        [JsonProperty("payload")]
        public DeparturePayload Departures { get; set; }
        public Meta Meta { get; set; }
    }

    public class DeparturePayload
    {
        public List<Departure> Departures { get; set; } = new List<Departure>()
    }

    public class Meta
    {
        public int NumberOfDisruptions { get; set; }
    }

    public class Departure
    {
        public string Direction { get; set; }
        public string Name { get; set; }
        public DateTimeOffset PlannedDateTime { get; set; }
        public int PlannedTimeZoneOffset { get; set; }
        public DateTimeOffset ActualDateTime { get; set; }
        public int ActualTimeZoneOffset { get; set; }
        public string PlannedTrack { get; set; }
        public string ActualTrack { get; set; }
        public Product Product { get; set; }
        public string TrainCategory { get; set; }
        public bool Cancelled { get; set; }
        public List<RouteStation> RouteStations { get; set; } = new List<RouteStation>();
        public string DepartureStatus { get; set; }
        public List<DepartureMessage> Messages { get; set; } = new List<DepartureMessage>();
    }

    public class RouteStation
    {
        public string UicCode { get; set; }
        public string MediumName { get; set; }
    }

    public class DepartureMessage
    {
        public string Message { get; set; }
        public string Style { get; set; }
    }

}
