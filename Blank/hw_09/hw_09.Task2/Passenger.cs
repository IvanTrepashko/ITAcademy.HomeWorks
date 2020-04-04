using System;
using System.Collections.Generic;
using System.Text;

namespace hw_09.Task2
{
    class Passenger
    {
        public Ticket Ticket { get; set; }
        public string FullName{ get; set; }
        public string Passport { get; set; }

        public Passenger()
        {
            Ticket = new Ticket();
        }
    }
}
