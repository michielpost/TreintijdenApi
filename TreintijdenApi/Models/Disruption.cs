using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models
{
    public class Disruption
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public string Titel { get; set; }
        public string Topic { get; set; }
        public Verstoring Verstoring { get; set; }
    }

    public class Reisadvies
    {
        public string Titel { get; set; }
        public List<string> Advies { get; set; }
    }

    public class Reisadviezen
    {
        public string Titel { get; set; }
        public List<Reisadvies> Reisadvies { get; set; }
    }

    public class Baanvakken
    {
        public List<string> Stations { get; set; }
    }

    public class Trajecten
    {
        public List<string> Stations { get; set; }
        public DateTimeOffset Begintijd { get; set; }
        public DateTimeOffset Eindtijd { get; set; }
        public string Richting { get; set; }
    }

    public class GeldigheidsLijst
    {
        public DateTimeOffset StartDatum { get; set; }
        public DateTimeOffset EindDatum { get; set; }
        public string StartTijd { get; set; }
        public string EindTijd { get; set; }
    }

    public class Verstoring
    {
        public string Id { get; set; }
        public Reisadviezen Reisadviezen { get; set; }
        public string Verwachting { get; set; }
        public string Gevolg { get; set; }
        public string GevolgType { get; set; }
        public string Fase { get; set; }
        public string AlternatiefVervoer { get; set; }
        public bool Landelijk { get; set; }
        public string Oorzaak { get; set; }
        public string Header { get; set; }
        public DateTime Meldtijd { get; set; }
        public string Type { get; set; }
        public List<Baanvakken> Baanvakken { get; set; }
        public List<Trajecten> Trajecten { get; set; }
        public string Versie { get; set; }
        public string Volgnummer { get; set; }
        public int Prioriteit { get; set; }
        public string ExtraReistijd { get; set; }
        public List<GeldigheidsLijst> GeldigheidsLijst { get; set; }
        public int? Impact { get; set; }
        public int? Maatschappij { get; set; }
        public string Periode { get; set; }
    }
}
