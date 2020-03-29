using System;

namespace hw_08.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Your string is : "+str);
                Console.WriteLine();
                Console.WriteLine("What do you want to do?\n1. Remove the largest word\n2. Replace the largest and the smallest words\n3. Count down characters\n4. Sort string\n5. Exit");
                int.TryParse(Console.ReadLine(),out int choice);
                switch (choice)
                {
                    case 1:
                        {
                            RemoveTheLargestWord(str);
                            Console.Read();
                            break;
                        }
                    case 2:
                        {
                            ReplaceWords(str);
                            Console.Read();
                            break;
                        }
                    case 3:
                        {
                            CountCharacters(str);
                            Console.Read();
                            break;
                        }
                    case 4:
                        {
                            SortString(str);
                            Console.Read();
                            break;
                        }
                    case 5:
                        {
                            return;
                        }
                }
                
            }

        }

        static void RemoveTheLargestWord(string str)
        {
            string[] arr = str.Split(' ');
            int index = 0;
            int maxLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > maxLength)
                {
                    index = i;
                    maxLength = arr[i].Length;
                }
            }
            int x = str.IndexOf(arr[index]);
            if (index == arr.Length - 1)
            {
                str = str.Remove(x, maxLength);
            }
            else str = str.Remove(x, maxLength + 1);
            str = str.Trim();
            Console.WriteLine("Result is : "+str);
        }

        static void ReplaceWords(string str)
        {
            string[] arr = str.Split(' ');
            int minIndex = 0;
            int minLength = 0;
            int maxIndex = 0;
            int maxLength = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > maxLength)
                {
                    maxIndex = i;
                    maxLength = arr[i].Length;
                }
            }
            minLength = maxLength;
            minIndex = maxIndex;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < minLength)
                {
                    minIndex = i;
                    minLength = arr[i].Length;
                }
            }
            string tmp = arr[minIndex];
            arr[minIndex] = arr[maxIndex];
            arr[maxIndex] = tmp;
            str=string.Join(' ', arr);
            Console.WriteLine("Result is : " + str);
        }

        static void CountCharacters(string str)
        {
            int letterCount = 0;
            int punctCount = 0;
            for (int i=0;i<str.Length;i++)
            {
                if (char.IsLetter(str[i]))
                    letterCount++;
                if (char.IsPunctuation(str[i]))
                    punctCount++;
            }
            Console.WriteLine("Number of letters is {0}",letterCount);
            Console.WriteLine("Number of punctuation symbols is {0}",punctCount);

        }

        static void SortString(string str)
        {
            string[] arr = str.Split(' ');
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            str = string.Join(' ', arr);
            Console.WriteLine("Result is : "+str);
        }
    }
}
