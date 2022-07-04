using System;

namespace _07_Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string enteredCoins = Console.ReadLine();

            double sumCoins = 0;

            while (enteredCoins != "Start")
            {
                double addedCoins = double.Parse(enteredCoins);

                if (addedCoins == 0.1 || addedCoins == 0.2 || addedCoins == 0.5 || addedCoins == 1 || addedCoins == 2)
                {
                    sumCoins += addedCoins;
                    enteredCoins = (Console.ReadLine());
                }

                else
                {
                    Console.WriteLine($"Cannot accept {enteredCoins}");
                    enteredCoins = (Console.ReadLine());
                }
            }

            enteredCoins = Console.ReadLine();

            while (enteredCoins != "End")
            {

                if (enteredCoins == "Nuts" && sumCoins >= 2)
                {
                    sumCoins -= 2;
                    Console.WriteLine($"Purchased nuts");
                }
                else if (enteredCoins == "Water" && sumCoins >= 0.7)
                {
                    sumCoins -= 0.7;
                    Console.WriteLine($"Purchased water");
                }
                else if (enteredCoins == "Crisps" && sumCoins >= 1.5)
                {
                    sumCoins -= 1.5;
                    Console.WriteLine($"Purchased crisps");
                }
                else if (enteredCoins == "Soda" && sumCoins >= 0.8)
                {
                    sumCoins -= 0.8;
                    Console.WriteLine($"Purchased soda");
                }
                else if (enteredCoins == "Coke" && sumCoins >= 1)
                {
                    sumCoins -= 1;
                    Console.WriteLine($"Purchased coke");
                }
                else
                {
                    if (enteredCoins != "Nuts" && enteredCoins != "Water" && enteredCoins != "Crisps" && enteredCoins != "Soda" && enteredCoins != "Coke")
                    {
                        Console.WriteLine("Invalid product");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                enteredCoins = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumCoins:f2}");
        }
    }
}
