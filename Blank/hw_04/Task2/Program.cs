using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string str;
            while (flag)
            {
                Console.WriteLine("Enter direction (W,S,A,D) to move. Enter '0' to exit, 'c' to clear console.");
                str = Console.ReadLine();
                if(str.Equals("0"))
                {
                    flag = false;
                    break;
                }
                if(str.Length!=1)
                {
                    Console.WriteLine("Wrong input (Too many characters). Try again.");
                }
                else
                {
                    char ch = Convert.ToChar(str);
                    switch (ch)
                    {
                        case 'w':
                            {
                                Console.WriteLine("Player moved forward.");
                                break;
                            }
                        case 's':
                            {
                                Console.WriteLine("Player moved back.");
                                break;
                            }
                        case 'a':
                            {
                                Console.WriteLine("Player moved left.");
                                break;
                            }
                        case 'd':
                            {
                                Console.WriteLine("Player moved right.");
                                break;
                            }
                        case 'c':
                            {
                                Console.Clear();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Wrong input! Try again.");
                                break;
                            }
                    }
                }
            }
        }
    }
}
