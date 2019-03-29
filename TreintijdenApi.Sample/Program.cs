using System;
using System.Linq;
using System.Threading.Tasks;
using TreintijdenApi.Models;

namespace TreintijdenApi.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter API Key:");
            var apiKey = Console.ReadLine();

            var api = TreintijdenClient.GetClient(apiKey);

            var stations = await api.GetAllStations();
            Console.WriteLine($"Found {stations.Stations.Count} stations");

            var disruptions = await api.GetDisruptions();
            Console.WriteLine($"Found {disruptions.Disruptions.Count} disruptions");

            var disruption = await api.GetDisruption(disruptions.Disruptions.First().Id);
            Console.WriteLine($"Disruption {disruptions.Disruptions.First().Id} is {disruption.Disruption.Titel}");

            var utrechtDisruptions = await api.GetStationDisruption("Üt");
            Console.WriteLine($"Found {utrechtDisruptions.Disruptions.Count} disruptions at Station Utrecht");

            var arrivals = await api.GetArrivals("Dt");
            var firstArrival = arrivals.Arrivals.Arrivals.First();
            Console.WriteLine($"Next arrival at Delft Station: {firstArrival.Name} from {firstArrival.Origin} at {firstArrival.ActualDateTime}");

            var departure = await api.GetDepartures("Dt", DateTimeOffset.UtcNow.AddDays(1));
            var firstdeparture = departure.Departures.Departures.First();
            Console.WriteLine($"Departure in 24h at Delft Station: {firstdeparture.Name} to {firstdeparture.RouteStations.Last().MediumName} {firstdeparture.DepartureStatus}");

            var trips = await api.GetTrips("Dt", "Ut", null, false, DateTimeOffset.UtcNow, false);
            Console.WriteLine($"Next trip from Dt to Ut duration: {trips.Trips.First().ActualDurationInMinutes}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();


        }
    }
}
