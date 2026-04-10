using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();

        Address address1 = new Address("200 University Ave", "Provo", "UT", "USA");
        Lecture lecture = new Lecture("C# and OOP", "A deep dive into object-oriented programming with C#.", "April 15, 2026", "10:00 AM", address1, "Dr. Jane Parker", 100);
        events.Add(lecture);

        Address address2 = new Address("50 Tech Blvd", "San Francisco", "CA", "USA");
        Reception reception = new Reception("Tech Networking Night", "Meet and connect with local tech professionals.", "April 22, 2026", "6:00 PM", address2, "rsvp@technightSF.com");
        events.Add(reception);

        Address address3 = new Address("1 Park Lane", "Denver", "CO", "USA");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Music Festival", "An outdoor celebration of local bands and food trucks.", "May 10, 2026", "2:00 PM", address3, "Sunny, 75°F, light breeze");
        events.Add(outdoor);

        foreach (Event e in events)
        {
            Console.WriteLine("--- Standard Details ---");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("--- Full Details ---");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("--- Short Description ---");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();

            Console.WriteLine("========================================");
            Console.WriteLine();
        }
    }
}
