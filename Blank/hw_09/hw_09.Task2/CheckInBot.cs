using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task2
{
    static class CheckInBot
    {
        public static void Greetings()
        {
            string greeting=string.Empty;

            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 13)
                greeting = "morning";
            else if (DateTime.Now.Hour >= 13 && DateTime.Now.Hour < 18)
                greeting = "afternoon";
            else if (DateTime.Now.Hour >= 18 && DateTime.Now.Hour < 24)
                greeting = "evening";
            else greeting = "night";

            Console.WriteLine($"Good {greeting}, sir. Welcome to the airport.");
        }

        public static void OnlineRegistration(ref Passenger passenger)
        {
            Console.WriteLine("Welcome to the online registration");
            Console.WriteLine("Please, enter your full name");
            passenger.FullName = Console.ReadLine();
            Console.WriteLine("Enter yout booking reference");
            passenger.Ticket.BookingReference = Console.ReadLine();

        }
    }
}
