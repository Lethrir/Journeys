using System;

namespace Journeys
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: journeys.exe <fileName>.txt");
            }

            var fileParser = new FileParser();
            var journeys = fileParser.GetJourneysFromFile(args[0]);
            var processor = new JourneyProcessor();
            foreach (var journey in journeys)
            {
                Console.WriteLine($"Checking journey starting at {journey.InitialState}");
                var result = processor.VerifyJourney(journey);
                Console.WriteLine(result ? "Journey Valid" : "Journey Invalid");
                Console.WriteLine($"Validated journey finishing at {journey.FinalState}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
