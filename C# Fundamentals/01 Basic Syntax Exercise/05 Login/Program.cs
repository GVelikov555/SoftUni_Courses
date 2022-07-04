using System;

namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string realpass = "";
            
            for (int i = username.Length - 1 ; i >= 0; i--)
            {
                realpass += username[i];
            }
            
            string password = Console.ReadLine();

            for (int i = 1; i < 5; i++)
            {
                if (password == realpass && i < 5)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (password != realpass && i < 4)  
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                if (i == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                password = Console.ReadLine();
            }
        }
    }
}
