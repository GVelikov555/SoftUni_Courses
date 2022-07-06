using System;

namespace _10_Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pokeEnergy = int.Parse(Console.ReadLine());
            int energyConsum = int.Parse(Console.ReadLine());
            int specialConsum = int.Parse(Console.ReadLine());
            double halfEnergy = pokeEnergy * 0.5;
            int pokedTargets = 0;
            int energyLeft = 0;

            for (energyLeft = pokeEnergy; energyLeft >= energyConsum; pokedTargets++)
            {
               energyLeft -= energyConsum;

                    if (energyLeft == halfEnergy & specialConsum != 0)
                    {
                        energyLeft /= specialConsum;
                    }
            }
            Console.WriteLine(energyLeft);
            Console.WriteLine(pokedTargets);
        }
    }
}
