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

            //var mLabApi = TreintijdenMLabClient.GetClient(apiKey);
            //var trainInfo = await mLabApi.GetTrainInfo("123");
            //Console.WriteLine($"Found {trainInfo.Lengte} treinlengte");


            var api = TreintijdenClient<ITreinApi>.GetClient(apiKey);

            var stations = await api.GetAllStations();
            Console.WriteLine($"Found {stations.Stations.Count} stations");

            var disruptions = await api.GetDisruptions();
            Console.WriteLine($"Found {disruptions.Count} disruptions");

            var firstDisruption = disruptions.First();
            var disruption = await api.GetDisruption(firstDisruption.Type, firstDisruption.Id);
            Console.WriteLine($"Disruption {disruptions.First().Id} is {disruption.Title}");

            var utrechtDisruptions = await api.GetStationDisruption("Ut");
            Console.WriteLine($"Found {utrechtDisruptions.Count} disruptions at Station Utrecht");

            var arrivals = await api.GetArrivals("Dt");
            var firstArrival = arrivals.Arrivals.Arrivals.First();
            Console.WriteLine($"Next arrival at Delft Station: {firstArrival.Name} from {firstArrival.Origin} at {firstArrival.ActualDateTime}");

            var departure = await api.GetDepartures("Dt", DateTimeOffset.UtcNow.AddDays(1));
            var firstdeparture = departure.Departures.Departures.FirstOrDefault();
            Console.WriteLine($"Departure in 24h at Delft Station: {firstdeparture?.Name} to {firstdeparture?.RouteStations.Last()?.MediumName} {firstdeparture?.DepartureStatus}");

            var trips = await api.GetTrips("Dt", "Ut", null,DateTimeOffset.UtcNow.AddDays(5), false, false, true);
            Console.WriteLine($"Next trip from Dt to Ut duration: {trips.Trips.First().ActualDurationInMinutes}");

            //var price = await api.GetPrice(DateTimeOffset.UtcNow, "Dt", "Ut");
            //Console.WriteLine($"Price from Dt to Ut: {price.PriceOptions.First().TotalPrices.First().Price}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();


        }
    }
}
