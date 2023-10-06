using System;
using _03_Event_Managment_System.Classes;


public class Program
{

    public static void Main(string[] args)
    {

        Guest guest1 = new Guest("Daichi", "Sawamura", 17);
        Guest guest2 = new Guest("Kōshi", "Sugawara", 17);
        Guest guest3 = new Guest("Asahi", "Azumane", 18);
        Guest guest4 = new Guest("Yū", "Nishinoya", 16);

        Performer performer1 = new Performer("Ryūnosuke", "Tanaka", 16, "spiker");
        Performer performer2 = new Performer("Chikara", "Ennoshita", 16, "captain");
        Performer performer3 = new Performer("Hisashi", "Kinoshita", 16, "server");

        Event event1 = new Event("Karasuno", "A big voleyball tournament");

        event1.AddAtendee(guest1);
        event1.AddAtendee(guest2);
        event1.AddAtendee(guest3);

        event1.AddAtendee(performer1);
        event1.AddAtendee(performer2);
        event1.AddAtendee(performer3);

        guest1.processInvitation(true);
        guest2.processInvitation(false);

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
        Console.WriteLine("");

        event1.RemoveAtendee("Daichi", "Sawamura");
        event1.RemoveAtendee("Asahi", "Azumane");

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
    }

}