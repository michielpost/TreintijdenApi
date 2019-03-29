using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models.Response
{
    public class GetTripsResponse
    {
        public List<Trip> Trips { get; set; }
        public string ScrollRequestBackwardContext { get; set; }
        public string ScrollRequestForwardContext { get; set; }
    }

    public class Location
    {
        public string Type { get; set; }
        public string PrognosisType { get; set; }
        public int PlannedTimeZoneOffset { get; set; }
        public DateTimeOffset PlannedDateTime { get; set; }
        public int ActualTimeZoneOffset { get; set; }
        public DateTimeOffset ActualDateTime { get; set; }
        public string PlannedTrack { get; set; }
        public string ExitSide { get; set; }
        public string CheckinStatus { get; set; }
        public List<Note> Notes { get; set; }
        public string Name { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
        public string CountryCode { get; set; }
        public string UicCode { get; set; }
        public int Weight { get; set; }
        public int Products { get; set; }
    }


    public class Note
    {
        public string Value { get; set; }
        public string Key { get; set; }
        public string NoteType { get; set; }
        public int Priority { get; set; }
        public int RouteIdxFrom { get; set; }
        public int RouteIdxTo { get; set; }
        public bool IsPresentationRequired { get; set; }
    }

    public class Stop
    {
        public List<Note> Notes { get; set; }
        public int RouteIdx { get; set; }
        public string DeparturePrognosisType { get; set; }
        public DateTimeOffset PlannedDepartureDateTime { get; set; }
        public int PlannedDepartureTimeZoneOffset { get; set; }
        public DateTimeOffset ActualDepartureDateTime { get; set; }
        public string PlannedDepartureTrack { get; set; }
        public DateTimeOffset PlannedArrivalDateTime { get; set; }
        public int PlannedArrivalTimeZoneOffset { get; set; }
        public string PlannedArrivalTrack { get; set; }
        public bool Cancelled { get; set; }
        public string Name { get; set; }
        public double Lng { get; set; }
        public double Lat { get; set; }
        public string CountryCode { get; set; }
        public string UicCode { get; set; }
        public bool? Passing { get; set; }
        public string ArrivalPrognosisType { get; set; }
        public DateTimeOffset? ActualArrivalDateTime { get; set; }
        public int? DepartureDelayInSeconds { get; set; }
        public int? ArrivalDelayInSeconds { get; set; }
    }

    public class Link
    {
        public string Uri { get; set; }
    }

    public class JourneyDetail
    {
        public string Type { get; set; }
        public Link Link { get; set; }
    }

    public class Leg
    {
        public string Idx { get; set; }
        public string Name { get; set; }
        public string TravelType { get; set; }
        public string Direction { get; set; }
        public bool Cancelled { get; set; }
        public bool ChangePossible { get; set; }
        public bool AlternativeTransport { get; set; }
        public string JourneyDetailRef { get; set; }
        public Location Origin { get; set; }
        public Location Destination { get; set; }
        public Product Product { get; set; }
        public List<Note> Notes { get; set; }
        //public List<object> Messages { get; set; }
        public List<Stop> Stops { get; set; }
       // public List<object> Steps { get; set; }
        public string CrowdForecast { get; set; }
        public double Punctuality { get; set; }
        public bool ShorterStock { get; set; }
        public List<JourneyDetail> JourneyDetail { get; set; }
        public bool Reachable { get; set; }
    }

    public class ProductFare
    {
        public int PriceInCents { get; set; }
        public string Product { get; set; }
        public string TravelClass { get; set; }
        public int? PriceInCentsExcludingSupplement { get; set; }
        public string DiscountType { get; set; }
    }

    public class Trip
    {
        public int PlannedDurationInMinutes { get; set; }
        public int Transfers { get; set; }
        public string Status { get; set; }
        public List<Leg> Legs { get; set; }
        public string Checksum { get; set; }
        public string CrowdForecast { get; set; }
        public double Punctuality { get; set; }
        public string CtxRecon { get; set; }
        public int ActualDurationInMinutes { get; set; }
        public int Idx { get; set; }
        public bool Optimal { get; set; }
        public List<ProductFare> Fares { get; set; }
        public ProductFare ProductFare { get; set; }
        public string Type { get; set; }
        public Link ShareUrl { get; set; }
        public bool Realtime { get; set; }
    }

}
