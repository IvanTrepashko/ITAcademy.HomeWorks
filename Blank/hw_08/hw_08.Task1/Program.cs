using System;

namespace hw_08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a poem in one string");
            string initialPoem;
            initialPoem = Console.ReadLine();
            string[] splittedPoem = initialPoem.Split(';');
            for (int i = 0; i < splittedPoem.Length; i++)
            {
                splittedPoem[i] = splittedPoem[i].Replace('O', 'A');
                splittedPoem[i] = splittedPoem[i].Trim();
            }
            foreach (string item in splittedPoem)
                Console.WriteLine(item);
        }
    }
}
