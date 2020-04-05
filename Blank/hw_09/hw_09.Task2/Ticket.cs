using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task2
{
    class Ticket
    {
        public DateTime ArrivalDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public string Destination { get; set; }
        public string BookingReference { get; set; }
        public short SeatNumber { get; set; }

        public void GetInformation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Destination : {Destination}.\nDeparture date : {DepartureDate}.\nArrival date : {ArrivalDate}.\nYour seat : {SeatNumber}.");
            Console.ResetColor();
        }

        public void SetInformation()
        {
            Random rnd = new Random();
            Console.WriteLine("Welcome to ticket booking site.");

            Console.WriteLine("Please, enter necessary destination.");
            Destination = Console.ReadLine();
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Please, enter departure date (YYYY-MM-DD)");
                    string str = Console.ReadLine();
                    string[] vs = str.Split('-');
                    DepartureDate = new DateTime(int.Parse(vs[0]), int.Parse(vs[1]), int.Parse(vs[2]), 18, 00, 00);
                    if (DepartureDate <= DateTime.Now)
                    {
                        Console.WriteLine("Wrong date. Please, try again.");
                    }
                    else
                    {
                        ArrivalDate = DepartureDate.AddHours(5);
                        flag = false;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong input. Please, try again.");
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                sb.Append((char)rnd.Next(65, 90));
            }
            SeatNumber =(short)rnd.Next(250);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Booking is complete.\nYour booking reference is : ");
            Console.WriteLine(sb.ToString());
            BookingReference = sb.ToString();
            Console.ResetColor();
        }
    }
}
