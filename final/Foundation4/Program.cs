using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create activities
            Activity running = new Running(new DateTime(2024, 7, 15), 30, 5.0); // 5 km run in 30 minutes
            Activity cycling = new Cycling(new DateTime(2024, 7, 16), 45, 20.0); // 20 kph cycling for 45 minutes
            Activity swimming = new Swimming(new DateTime(2024, 7, 17), 30, 20); // 20 laps in 30 minutes

            // Add activities to a list
            List<Activity> activities = new List<Activity> { running, cycling, swimming };

            // Display summaries
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
                Console.WriteLine();
            }
        }
    }
}
