using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[7];
            Console.WriteLine("Enter values for array");
            for (int i = 0; i < arr.Length - 1; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            foreach(int x in arr)
                Console.Write(x+" ");
            Console.WriteLine();
            Console.WriteLine("Enter additional value and its position");
            int value = Convert.ToInt32(Console.ReadLine());
            int pos = Convert.ToInt32(Console.ReadLine());
            for (int i = arr.Length - 2; i>=pos-1; i--)
            {
                arr[i + 1] = arr[i];
            }
            arr[pos-1] = value;
            foreach (int x in arr)
                Console.Write(x + " ");
        }
    }
}
