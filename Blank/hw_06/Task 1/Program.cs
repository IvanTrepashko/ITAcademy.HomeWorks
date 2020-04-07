using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr1 = new int[7];
            int[] arr2 = new int[7];
            int[] arr3 = new int[7];
            for (int i = 0; i<arr1.Length; i++)
            {
                arr1[i] = random.Next(40);
            }
            Console.WriteLine("Enter values for the 2nd array");
            for (int i=0;i<arr2.Length;i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i=0;i<arr3.Length;i++)
            {
                arr3[i] = arr1[i] + arr2[i];
            }
            Console.Write("1st array is : ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]+ " ");
            }
            Console.WriteLine();
            Console.Write("2nd array is : ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]+" ");
            }
            Console.WriteLine();
            Console.Write("3rd array is : ");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i]+" ");
            }
        }
    }
}
