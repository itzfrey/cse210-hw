using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("456 History Blvd", "Past City", "Lima", "Peru");

        Lecture lecture = new Lecture("History Lecture: 'Ancient Civilizations'", "Discover the fascinating history of ancient civilizations", "December 29, 2023", "2 PM", address1, "Dr. Isere", 90);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address address2 = new Address("707 Poplar Ave", "Downtown", "AZ", "USA");

        Reception reception = new Reception("Celebration: 'Annual Company Gala'", "Join us for a night of festivities and awards", "December 10, 2023", "7 PM", address2, "annualcompanygala.org");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address address3 = new Address("404 Elm Ln", "Metropolis", "Ga", "USA");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Gathering: 'Green Initiative'", "Discussing environmental sustainability and community projects", "September 16, 2023", "2 PM", address3, "Sunny");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}