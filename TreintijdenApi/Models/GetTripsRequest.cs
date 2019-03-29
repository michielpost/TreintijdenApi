using RestEase;
using System;
using System.Collections.Generic;
using System.Text;

namespace TreintijdenApi.Models
{
   public class GetTripsRequest
    {
        [Query("originLat")]
        public string OriginLat { get; set; }

        [Query("originLng")]
        public string OriginLng { get; set; }

        [Query("destinationLat")]
        public string DestinationLat { get; set; }

        [Query("destinationLng")]
        public string DestinationLng { get; set; }

        [Query("viaLat")]
        public string ViaLat { get; set; }

        [Query("viaLng")]
        public string ViaLng { get; set; }

        [Query("viaWaitTime")]
        public int? ViaWaitTime { get; set; }

        [Query("dateTime")]
        public DateTimeOffset DateTime { get; set; }

        [Query("searchForArrival")]
        public bool? SearchForArrival { get; set; }

        [Query("previousAdvices")]
        public int? PreviousAdvices { get; set; }

        [Query("nextAdvices")]
        public int? NextAdvices { get; set; }

        [Query("context")]
        public string Context { get; set; }

        [Query("addChangeTime")]
        public int? AddChangeTime { get; set; }

        [Query("lang")]
        public string Lang { get; set; }

        [Query("polylines")]
        public bool? Polylines { get; set; }

        /// <summary>
        /// Name/constant of product customer will use in travel, if omitted defaults to ROS
        /// </summary>
        [Query("product")]
        public string Product { get; set; }

        [Query("travelClass")]
        public string TravelClass { get; set; }

        [Query("discount")]
        public string Discount { get; set; }

        [Query("productStationFrom")]
        public string ProductStationFrom { get; set; }

        [Query("productStationTo")]
        public string ProductStationTo { get; set; }

        [Query("yearCard")]
        public bool? YearCard { get; set; }

        [Query("originTransit")]
        public bool? OriginTransit { get; set; }

        [Query("originWalk")]
        public bool? OriginWalk { get; set; }

        [Query("originBike")]
        public bool? OriginBike { get; set; }

        [Query("originCar")]
        public bool? OriginCar { get; set; }

        [Query("originName")]
        public string OriginName { get; set; }

        [Query("travelAssistanceTransferTime")]
        public int TravelAssistanceTransferTime { get; set; }

        [Query("searchForAccessibleTrip")]
        public bool? SearchForAccessibleTrip { get; set; }

        [Query("destinationTransit")]
        public bool? DestinationTransit { get; set; }

        [Query("destinationWalk")]
        public bool? DestinationWalk { get; set; }

        [Query("destinationBike")]
        public bool? DestinationBike { get; set; }

        [Query("destinationCar")]
        public bool? DestinationCar { get; set; }

        [Query("destinationName")]
        public string DestinationName { get; set; }

        [Query("accessibilityEquipment1")]
        public string AccessibilityEquipment1 { get; set; }

        [Query("accessibilityEquipment2")]
        public string AccessibilityEquipment2 { get; set; }

        [Query("excludeHighSpeedTrains")]
        public bool? ExcludeHighSpeedTrains { get; set; }

        [Query("excludeReservationRequired")]
        public bool? ExcludeReservationRequired { get; set; }

        [Query("passing")]
        public bool? Passing { get; set; }

        [Query("travelRequestType")]
        public string TravelRequestType { get; set; }

        [Query("originEVACode")]
        public string OriginEVACode { get; set; }

        [Query("destinationEVACode")]
        public string DestinationEVACode { get; set; }

        [Query("viaEVACode")]
        public string ViaEVACode { get; set; }

        [Query("shorterChange")]
        public bool? ShorterChange { get; set; }

        [Query("fromStation")]
        public string FromStation { get; set; }

        [Query("toStation")]
        public string ToStation { get; set; }

        [Query("originUicCode")]
        public string OriginUicCode { get; set; }

        [Query("destinationUicCode")]
        public string DestinationUicCode { get; set; }

        [Query("viaUicCode")]
        public string ViaUicCode { get; set; }

        [Query("bikeCarriageRequired")]
        public bool? BikeCarriageRequired { get; set; }

        [Query("viaStation")]
        public string ViaStation { get; set; }

        [Query("departure")]
        public bool? Departure { get; set; }

        [Query("minimalChangeTime")]
        public int? MinimalChangeTime { get; set; }
    }
}
