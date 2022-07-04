using System;

namespace _11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int order = int.Parse(Console.ReadLine());

            double total = 0;
            
            for (int i = 1; i <= order; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                
                double orderPrice = (days * capsules) * pricePerCapsule;
                
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                
                total += orderPrice;
                orderPrice = 0;
            }
            
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
