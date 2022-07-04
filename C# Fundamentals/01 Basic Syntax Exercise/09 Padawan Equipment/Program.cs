using System;

namespace _09_Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float moneyBudgjet = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float lightsaberPrize = float.Parse(Console.ReadLine());
            float robePrize = float.Parse(Console.ReadLine());
            float beltPrize = float.Parse(Console.ReadLine());

            double neededLightsabers = students * 1.1;
            neededLightsabers = Math.Ceiling(neededLightsabers);

            float lightsaberCost = (float)(lightsaberPrize * neededLightsabers);

            float robeCost = robePrize * students;

            float beltCost = 0;

            if (students / 6 != 0)
            {
                students -= students / 6;
                beltCost = beltPrize * students;
            }
            else
            {
                beltCost = beltPrize * students;
            }
            float fullCost = lightsaberCost + robeCost + beltCost;

            if (fullCost <= moneyBudgjet)
            {
                Console.WriteLine($"The money is enough - it would cost {fullCost:f2}lv.");
            }
            else
            {
                float neededMoreMoney = fullCost - moneyBudgjet;
                Console.WriteLine($" John will need {neededMoreMoney:f2}lv more.");
            }
        }
    }
}
