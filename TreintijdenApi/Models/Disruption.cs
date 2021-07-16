using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models
{
    public class Disruption
    {
        public string Id { get; set; }
        public string Type { get; set; }
        public DateTime RegistrationTime { get; set; }
        public DateTime ReleaseTime { get; set; }
        public bool Local { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public bool IsActive { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Phase Phase { get; set; }
        public Impact Impact { get; set; }
        public ExpectedDuration ExpectedDuration { get; set; }
        public SummaryAdditionalTravelTime SummaryAdditionalTravelTime { get; set; }
        public List<PublicationSection> PublicationSections { get; set; }
        public List<Timespan> Timespans { get; set; }
        public List<AlternativeTransportTimespan> AlternativeTransportTimespans { get; set; }
        public string Period { get; set; }
    }

    public class Phase
    {
        public string Id { get; set; }
        public string Label { get; set; }
    }

    public class Impact
    {
        public int Value { get; set; }
    }

    public class ExpectedDuration
    {
        public string Description { get; set; }
        public DateTime EndTime { get; set; }
    }

    public class SummaryAdditionalTravelTime
    {
        public string Label { get; set; }
        public string ShortLabel { get; set; }
        public int MinimumDurationInMinutes { get; set; }
        public int? MaximumDurationInMinutes { get; set; }
    }

    public class Coordinate
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }

    public class Station
    {
        public string UicCode { get; set; }
        public string StationCode { get; set; }
        public string Name { get; set; }
        public Coordinate Coordinate { get; set; }
        public string CountryCode { get; set; }
    }

    public class Section
    {
        public List<Station> Stations { get; set; }
        public string Direction { get; set; }
    }

    public class Consequence
    {
        public Section Section { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
    }

    public class PublicationSection
    {
        public Section Section { get; set; }
        public Consequence Consequence { get; set; }
        public string SectionType { get; set; }
    }

    public class Situation
    {
        public string Label { get; set; }
    }

    public class Cause
    {
        public string Label { get; set; }
    }

    public class AdditionalTravelTime
    {
        public string Label { get; set; }
        public string ShortLabel { get; set; }
        public int MinimumDurationInMinutes { get; set; }
        public int? MaximumDurationInMinutes { get; set; }
    }

    public class AlternativeTransport
    {
        public string Label { get; set; }
        public string ShortLabel { get; set; }
    }

    public class Timespan
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Situation Situation { get; set; }
        public Cause Cause { get; set; }
        public AdditionalTravelTime AdditionalTravelTime { get; set; }
        public AlternativeTransport AlternativeTransport { get; set; }
        public List<string> Advices { get; set; }
        public string Period { get; set; }
    }

    public class AlternativeTransportTimespan
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public AlternativeTransport AlternativeTransport { get; set; }
    }
}
