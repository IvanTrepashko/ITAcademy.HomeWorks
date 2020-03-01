using System;
using System.IO;
namespace hw_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader textReader = new StreamReader(@"D:\hw_2\image.txt");
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }
            File.WriteAllBytes(@"D:\hw_2\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}


