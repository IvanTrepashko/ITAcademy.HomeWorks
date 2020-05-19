using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task2
{
    static class CheckInBot
    {
        const string AirportName = "Minsk International Airport";

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

            Console.WriteLine($"Good {greeting}, sir. Welcome to the {AirportName}.");
        }

        public static void OnlineRegistration(ref Passenger passenger)
        {
            Random rnd = new Random();
            string bookingReferense;

            Console.WriteLine("Welcome to the online registration.");
            Console.WriteLine("Please, enter your booking referense.");
            while (true)
            {
                bookingReferense = Console.ReadLine();
                Console.WriteLine();
                if (passenger.Ticket.BookingReference.Equals(bookingReferense))
                {
                    passenger.Ticket.GetInformation();
                    Console.WriteLine();
                    Console.WriteLine("Registration is over.");
                    passenger.SetBoardingPass();
                    Console.WriteLine("Here is your boarding pass :");
                    passenger.BoardingPass.GetInformation();
                    Console.WriteLine();
                    Console.WriteLine("You can print your boarding pass at home or at the airport. Enjoy your flight!");
                    Console.ReadLine();
                    return;
                }
                else Console.WriteLine("Wrong booking reference. Please, try again.");
            }
        }

        public static void ReseptionRegistration(ref Passenger passenger) 
        {
            string fullName;
            string passportID;
            Greetings();
            Console.WriteLine("Please, enter your full name.");
            while(!(fullName = Console.ReadLine()).Equals(passenger.FullName))
            {
                Console.WriteLine("There is no people with such name. Please, try again.");
            }
            Console.WriteLine("Please, enter your passport ID.");
            while (!(passportID=Console.ReadLine()).Equals(passenger.PassportID))
            {
                Console.WriteLine("There is no people with such passport ID. Please, try again.");
            }
            Console.WriteLine();
            passenger.Ticket.GetInformation();
            Console.WriteLine();
            passenger.SetBoardingPass();
            Console.WriteLine("Registration is over. Please, take your boarding pass.");
            passenger.BoardingPass.GetInformation();
            Console.ReadLine();
        }
    }
}
