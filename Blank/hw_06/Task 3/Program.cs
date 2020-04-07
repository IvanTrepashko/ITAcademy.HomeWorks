using System;
using System.Diagnostics;
namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            long [] arr = new long[100_000_000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next();
            }
            long tmp;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i=0,j=arr.Length-1;i<j;i++,j--)
            {
                tmp = arr[i];
                arr[i] = arr[j];
                arr[j] = tmp;
            }
            stopwatch.Stop();
            Console.WriteLine("My own method : " + stopwatch.ElapsedMilliseconds);
            stopwatch.Reset();
            stopwatch.Start();
            Array.Reverse(arr);
            stopwatch.Stop();
            Console.WriteLine("Reverse method : " +stopwatch.ElapsedMilliseconds);
        }
    }
}
