using System;

namespace hw_09.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger passenger = new Passenger();
            ushort choice;
            Console.Write("Choose suitable way of registration.\n1. Online registration.\n2. Registration in the airport.\nYour choice : ");
            while(!(ushort.TryParse(Console.ReadLine(), out choice)))
                Console.WriteLine("Wrong input");
                switch (choice)
                {
                    case 1:
                        {
                            Console.Clear();
                            CheckInBot.OnlineRegistration(ref passenger);
                            break;
                         }
                    case 2:
                        {

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input. Please, try again");
                            break;
                        }
                }
            CheckInBot.Greetings();

        }
    }
}
