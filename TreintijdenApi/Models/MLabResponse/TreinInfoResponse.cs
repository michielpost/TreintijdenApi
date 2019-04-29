using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.MLabResponse
{
    public class Materieeldelen
    {
        public int Materieelnummer { get; set; }
        public string Type { get; set; }
        public List<string> Faciliteiten { get; set; }
        public string Afbeelding { get; set; }
        public string Eindbestemming { get; set; }
    }

    public class TreinInfoResponse
    {
        public string Bron { get; set; }
        public int Ritnummer { get; set; }
        public string Station { get; set; }
        public string Type { get; set; }
        public string Vervoerder { get; set; }
        public string Spoor { get; set; }
        public List<Materieeldelen> Materieeldelen { get; set; }
        public bool Ingekort { get; set; }
        public int Lengte { get; set; }
        public int LengteInMeters { get; set; }
        public int LengteInPixels { get; set; }
        public List<string> Debug { get; set; }
    }
}
