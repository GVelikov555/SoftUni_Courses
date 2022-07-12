using System;

namespace _03_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] lineSplit = line.Split('\\');
            int length = lineSplit.Length;
            string fileNameWithExtention = lineSplit[length - 1];
            string[] words = fileNameWithExtention.Split('.');
            string fileName = words[0];
            string extention = words[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
