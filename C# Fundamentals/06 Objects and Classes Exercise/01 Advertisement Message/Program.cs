using System;

namespace _01_Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[]
            {
                "Excellent product.", 
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" 
            };
            string[] authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            string[] cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            int numsOforderedFakeAdd = int.Parse(Console.ReadLine());

            Random randomphrase = new Random();
            Random randomEvent = new Random();
            Random randomAuthor = new Random();
            Random randomCity = new Random();


            for (int i = 1; i <= numsOforderedFakeAdd; i++)
            {
                int randomPhraseIndex = randomphrase.Next(0, phrases.Length);
                int randomEventIndex = randomEvent.Next(0, events.Length);
                int randomAuthorIndex = randomAuthor.Next(0, authors.Length);
                int randomCityIndex = randomCity.Next(0, cities.Length);
                Console.WriteLine($"{phrases[randomPhraseIndex]} {events[randomEventIndex]} {authors[randomAuthorIndex]} – {cities[randomCityIndex]}.");
            }
        }

        
    }
}
