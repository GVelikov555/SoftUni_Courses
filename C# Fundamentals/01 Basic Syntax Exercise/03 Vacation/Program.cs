using System;

namespace _03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double pricePerPerson = 0;
            double groupPrice = 0;

            if (dayOfWeek == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    pricePerPerson = 8.45;
                }
                else if (typeOfGroup == "Business")
                {
                    pricePerPerson = 10.90;
                }
                else if (typeOfGroup == "Regular")
                {
                    pricePerPerson = 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    pricePerPerson = 9.80;
                }
                else if (typeOfGroup == "Business")
                {
                    pricePerPerson = 15.60;
                }
                else if (typeOfGroup == "Regular")
                {
                    pricePerPerson = 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    pricePerPerson = 10.46;
                }
                else if (typeOfGroup == "Business")
                {
                    pricePerPerson = 16;
                }
                else if (typeOfGroup == "Regular")
                {
                    pricePerPerson = 22.50;
                }
            }

            groupPrice = pricePerPerson * countOfPeople;
            
            if (typeOfGroup == "Students" && countOfPeople >= 30)
            {
                groupPrice *= 0.85;
            }
            else if (typeOfGroup == "Business"&& countOfPeople >= 100)
            {
                groupPrice = pricePerPerson * (countOfPeople - 10 );
            }
            else if (typeOfGroup == "Regular" && countOfPeople >= 10 && countOfPeople <= 20)
            {
                groupPrice *= 0.95;
            }
            Console.WriteLine($"Total price: {groupPrice:f2}");

        }
    }
}
