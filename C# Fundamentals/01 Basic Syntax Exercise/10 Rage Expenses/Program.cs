using System;

namespace _10_Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine());
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());

            int trashHeadset = 0;
            int trashMouse = 0;
            int trashKeyboard = 0;
            int trashDisplay = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    trashHeadset += 1; 
                }
                if (i % 3 == 0)
                {
                    trashMouse += 1;
                }
                if (i % 6 == 0)
                {
                    trashKeyboard += 1;
                }
                if (i % 12 == 0)
                {
                    trashDisplay += 1;
                }
            }
            float totalPrice = trashHeadset * headsetPrice + trashMouse * mousePrice + trashKeyboard * keyboardPrice + trashDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
            
        }
    }
}
