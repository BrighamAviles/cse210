using System;
using System.Collections.Generic;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
            Address address3 = new Address("789 Oak St", "Vancouver", "BC", "Canada");

            // Create events
            Event lecture = new Lecture("Advanced C# Techniques", "A lecture on advanced topics in C#", new DateTime(2024, 8, 15), "10:00 AM", address1, "John Doe", 100);
            Event reception = new Reception("Company Annual Gala", "Annual company-wide gala event", new DateTime(2024, 9, 10), "7:00 PM", address2, "rsvp@example.com");
            Event outdoorGathering = new OutdoorGathering("Community Picnic", "A fun day out in the park with family and friends", new DateTime(2024, 7, 20), "12:00 PM", address3, "Sunny with a chance of clouds");

            // Create a list of events
            List<Event> events = new List<Event> { lecture, reception, outdoorGathering };

            // Display event details
            foreach (Event ev in events)
            {
                Console.WriteLine("Standard Details:");
                Console.WriteLine(ev.StandardDetails());
                Console.WriteLine();

                Console.WriteLine("Full Details:");
                Console.WriteLine(ev.FullDetails());
                Console.WriteLine();

                Console.WriteLine("Short Description:");
                Console.WriteLine(ev.ShortDescription());
                Console.WriteLine();
            }
        }
    }
}
