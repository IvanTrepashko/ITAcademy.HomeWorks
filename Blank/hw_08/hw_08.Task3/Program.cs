using System;
using System.Text;

namespace hw_08.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Console.WriteLine("Enter a string");
            sb.Append(Console.ReadLine());
            int i = 0;
            while (sb[i] != '?')
            {
                i++;
            }
            sb.Replace('!', ' ', 0, i);
            sb.Replace('.', ' ', 0, i);
            sb.Replace(" ", string.Empty, 0, i);
            i = 0;
            while (sb[i] != '?')
            {
                i++;
            }
            sb.Replace(' ', '_', i, sb.Length - i);
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.ToString());
        }
    }
}
