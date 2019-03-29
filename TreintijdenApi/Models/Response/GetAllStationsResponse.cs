using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.Response
{
    public class GetAllStationsResponse
    {
        [JsonProperty("payload")]
        public List<Station> Stations { get; set; }
    }

    public class Station
    {
        public List<Spoor> Sporen { get; set; }
        public List<string> Synoniemen { get; set; }
        public bool HeeftFaciliteiten { get; set; }
        public bool HeeftVertrektijden { get; set; }
        public bool HeeftReisassistentie { get; set; }
        public string Code { get; set; }
        public Namen Namen { get; set; }
        public string StationType { get; set; }
        public string Land { get; set; }
        public string UICCode { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public int Radius { get; set; }
        public int NaderenRadius { get; set; }
        public string EVACode { get; set; }
    }

    public class Spoor
    {
        public string SpoorNummer { get; set; }
    }

    public class Namen
    {
        public string Lang { get; set; }
        public string Kort { get; set; }
        public string Middel { get; set; }
    }

}
