using System;
using System.Numerics;
namespace _11_Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ballsCount = int.Parse(Console.ReadLine()); 
            
            int bestSnow = 0;
            int bestTime = 0;
            int bestQc = 0;
            
            BigInteger bestBall = 0;
            
            for (int i = ballsCount; i >= 1; i--)
            {
                int ballSnow = int.Parse(Console.ReadLine());
                int ballTime = int.Parse(Console.ReadLine());
                int ballQc = int.Parse(Console.ReadLine());
                
                    BigInteger ballValue = BigInteger.Pow(ballSnow / ballTime, ballQc);
                    
                    if (ballValue > bestBall)
                    {
                        bestBall = ballValue;
                        bestSnow = ballSnow;
                        bestTime = ballTime;
                        bestQc = ballQc;
                    }

            }
            
            Console.WriteLine($"{bestSnow} : {bestTime} = {bestBall} ({bestQc})");
            
        }
    }
}
