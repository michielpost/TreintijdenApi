using RestEase;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TreintijdenApi.Models;
using TreintijdenApi.Models.Response;

namespace TreintijdenApi
{
    internal class DateTimeFormat
    {
        public const string RFC3339DateFormat = "yyyy-MM-dd'T'HH:mm:ss.fffK";
    }

    public interface ITreinApi : IBaseNsApi
    {
        /// <summary>
        /// List of stations
        /// </summary>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v2/stations")]
        Task<GetAllStationsResponse> GetAllStations();

        /// <summary>
        /// Arrival times for a specified station. Either the UIC code or station is required
        /// </summary>
        /// <param name="station"></param>
        /// <param name="dateTime"></param>
        /// <param name="maxJourneys"></param>
        /// <param name="lang"></param>
        /// <param name="uicCode"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v2/arrivals")]
        Task<GetArrivalsResponse> GetArrivals(
            [Query("station")]string station,
            [Query("dateTime", Format = DateTimeFormat.RFC3339DateFormat)]DateTimeOffset? dateTime = null,
            [Query("maxJourneys")]int? maxJourneys = null,
            [Query("lang")]string lang = null,
            [Query("uicCode")]string uicCode = null,
            [Query("source")]string source = null
            );

        /// <summary>
        /// Departure times for a specified station. Either the UIC code or station is required.
        /// </summary>
        /// <param name="station"></param>
        /// <param name="dateTime"></param>
        /// <param name="maxJourneys"></param>
        /// <param name="lang"></param>
        /// <param name="uicCode"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v2/departures")]
        Task<GetDeparturesResponse> GetDepartures(
         [Query("station")]string station,
         [Query("dateTime", Format = DateTimeFormat.RFC3339DateFormat)]DateTimeOffset? dateTime = null,
         [Query("maxJourneys")]int? maxJourneys = null,
         [Query("lang")]string lang = null,
         [Query("uicCode")]string uicCode = null,
         [Query("source")]string source = null
        );

        /// <summary>
        /// Returns a large list of departure times for a specified station. Either the UICCode or station is required. Note: This request returns a large amount of data, if not necessary use the non big request..
        /// </summary>
        /// <param name="station"></param>
        /// <param name="dateTime"></param>
        /// <param name="maxJourneys"></param>
        /// <param name="lang"></param>
        /// <param name="uicCode"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v2/departures/big")]
        Task<GetDeparturesResponse> GetDeparturesBig(
            [Query("station")]string station,
            [Query("dateTime", Format = DateTimeFormat.RFC3339DateFormat)]DateTimeOffset? dateTime = null,
            [Query("maxJourneys")]int? maxJourneys = null,
            [Query("lang")]string lang = null,
            [Query("uicCode")]string uicCode = null,
            [Query("source")]string source = null
            );

        /// <summary>
        /// List of disruptions/maintenance
        /// </summary>
        /// <param name="type">storing or werkzaamheid</param>
        /// <param name="actual"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v3/disruptions")]
        Task<List<Disruption>> GetDisruptions(
            [Query("type")]string type = null,
            [Query("actual")]bool? actual = null,
            [Query("lang")]string lang = null
            );

        /// <summary>
        /// Specific disruption/maintenance
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v3/disruptions/{type}/{id}")]
        Task<Disruption> GetDisruption([Path("type")] string type, [Path("id")]string id);

        /// <summary>
        /// Disruptions for a station, code is either a UIC code or old-skool station code
        /// </summary>
        /// <param name="code">The UICCode or the station code</param>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v3/disruptions/station/{code}")]
        Task<List<Disruption>> GetStationDisruption([Path("code")]string code);

        /// <summary>
        /// Searches for a travel advice with the specified options between the possible backends (HARP, 9292 or PAS/AVG).
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [Get("/reisinformatie-api/api/v3/trips")]
        Task<GetTripsResponse> GetTrips(
            [Query("fromStation")]string fromStation,
            [Query("toStation")]string toStation,
            [Query("viaStation")]string viaStation,
            [Query("dateTime", Format = DateTimeFormat.RFC3339DateFormat)] DateTimeOffset dateTime,
            [Query("departure")]bool isDepartureTime = false,
            [Query("yearCard")]bool? yearCard = false,
            [Query("excludeHighSpeedTrains")]bool excludeHighSpeedTrains = true,
            [Query("previousAdvices")]int previousAdvices = 8,
            [Query("nextAdvices")]int nextAdvices = 8
         );

        //Needs a custom serializer
        // Task<GetTripsResponse> GetTrips([Query(QuerySerializationMethod.ToString)]GetTripsRequest request);

    }
}
