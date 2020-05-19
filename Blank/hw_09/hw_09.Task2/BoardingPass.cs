using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task2
{
    class BoardingPass
    {
        public string FlightNumber { get; set; }
        public DateTime ArrivalDate { get; set; }
        public short SeatNumber { get; set; }

        public BoardingPass(Ticket ticket)
        {
            Random rnd = new Random();
            ArrivalDate = ticket.ArrivalDate;
            SeatNumber = ticket.SeatNumber;
            FlightNumber = rnd.Next(999999).ToString();
        }

        public void GetInformation()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Flight number: {FlightNumber}.\nArrival date: {ArrivalDate}.\nYour seat: {SeatNumber}.");
            Console.ResetColor();
        }
    }
}
