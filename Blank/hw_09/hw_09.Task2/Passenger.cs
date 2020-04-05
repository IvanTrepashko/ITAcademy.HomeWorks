using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task2
{
    class Passenger
    {
        public Ticket Ticket { get; set; }
        public string FullName{ get; set; }
        public string PassportID { get; set; }
        public BoardingPass BoardingPass { get; set; }

        public Passenger()
        {
            Ticket = new Ticket();
        }

        public void SetBoardingPass()
        {
            BoardingPass = new BoardingPass(Ticket);
        }

        public void SetInformation()
        {
            Console.WriteLine("Hello! Please, enter your full name\n");
            FullName = Console.ReadLine();
            Console.WriteLine("Please, enter you passport ID (Example : AB2901224)");
            PassportID = Console.ReadLine();
            Console.Clear();
            Ticket.SetInformation();
        }
    }
}
