using System;

namespace _08_Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numbersOfKegs = byte.Parse(Console.ReadLine());
           
            decimal biggestKeg = 0;
            string kegName = "";

            for (int i = 0; i < numbersOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                float kegRadius = float.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                decimal volume = (decimal)(Math.PI * (Math.Pow(kegRadius, 2) * kegHeight));
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    kegName = kegModel; 
                }
            }
            Console.WriteLine(kegName);
        }
    }
}
