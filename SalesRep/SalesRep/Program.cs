using SalesRep_OOP;
using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        List<SalesRep> salesReps = new List<SalesRep>
        {
            new SalesRep("John", 40.7128, -74.0060),  // New York City
            new SalesRep("Alice", 34.0522, -118.2437),  // Los Angeles
            new SalesRep("Bob", 41.8781, -87.6298),  // Chicago
            new SalesRep("Eva", 29.7604, -95.3698),  // Houston
            new SalesRep("Sam", 33.4484, -112.0740)  // Phoenix
        };

        Console.WriteLine("Sales Rep Coordination Monitor");

        // Calculate and display the coordination of sales reps
        for (int i = 0; i < salesReps.Count; i++)
        {
            for (int j = i + 1; j < salesReps.Count; j++)
            {
                double distance = salesReps[j].CalculateDistance(
                    salesReps[i].Latitude, salesReps[i].Longitude,
                    salesReps[j].Latitude, salesReps[j].Longitude);

                Console.WriteLine($"{salesReps[i].Name} and {salesReps[j].Name} are {distance:F2} kilometers apart.");
            }
        }
    }


}