using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=(int)'z'; i>=(int)'a'; i--)
            {
                Console.Write((char)i+" ");
            }
            Console.WriteLine();
            for (int i = (int)'Z'; i >= (int)'A'; i--)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
