using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Activity objects
        // Polymorphism: the list holds the base type but stores derived objects
        List<Activity> activities = new List<Activity>();

        // Create one of each activity type and add to the list
        activities.Add(new Running("03 Nov 2022", 30, 3.0));
        activities.Add(new Cycling("03 Nov 2022", 30, 9.7));
        activities.Add(new Swimming("03 Nov 2022", 30, 20));

        // Iterate through the list and display the summary for each
        // Polymorphism in action: GetSummary() calls the correct
        // GetDistance(), GetSpeed(), GetPace() for each activity type
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}