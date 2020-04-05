using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task2
{
    static class AirportScreeningBot
    {
        public static void Screening(Passenger passenger)
        {
            Console.Clear();
            Console.WriteLine($"Welcome to airport screening, {passenger.FullName}.");
            Console.WriteLine("You are required to submit to a body search.\nDo you have any hand luggage? (Yes/No)");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Yes":
                    {
                        Console.WriteLine("Ok, put your hand luggage into this plastic box and then go through metal detector.");
                        break;
                    }
                case "No":
                    {
                        Console.WriteLine("Ok, then just go through metal detector.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong input.");
                        break;
                    }
            }
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine();
            Console.WriteLine("Now you have to go through passport control.");
            Console.WriteLine("Please, enter your passport ID.");

            while (!(Console.ReadLine().Equals(passenger.PassportID)))
            {

                Console.WriteLine("Seems like you entered wrong passport ID. Please, try again.");
            }
            Console.WriteLine($"Everything is alright. Enjoy your flight, {passenger.FullName}.");
        }

        public static void Baggage(Passenger passenger)
        {
            Console.Clear();
            Console.WriteLine($"Do you have any baggage, {passenger.FullName}? (Yes/No)");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "Yes":
                    {
                        Console.WriteLine("Ok, put your baggage on this conveyor belt. It will be deliveried into your plane.");
                        break;
                    }
                case "No":
                    {
                        Console.WriteLine("Ok, then you can go to screening.");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Wrong input.");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
