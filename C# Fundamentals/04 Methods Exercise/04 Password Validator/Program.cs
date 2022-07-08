using System;

namespace _04_Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool ifMeetLenghtReq = CheckPassLenght(password);
            bool ifHasQnlyLettersAndDigits = CheckForCorrectSymbols(password);
            bool ifHasMinReqDigits = CheckMinReqDigits(password);

            if (ifMeetLenghtReq & ifHasQnlyLettersAndDigits & ifHasMinReqDigits)
            {
                Console.WriteLine("Password is valid");
            }
            
            else if (!ifMeetLenghtReq & ifHasQnlyLettersAndDigits & ifHasMinReqDigits)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            
            else if (ifMeetLenghtReq & !ifHasQnlyLettersAndDigits & ifHasMinReqDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            
            else if (ifMeetLenghtReq & ifHasQnlyLettersAndDigits & !ifHasMinReqDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            else if (!ifMeetLenghtReq & !ifHasQnlyLettersAndDigits & ifHasMinReqDigits)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                Console.WriteLine("Password must consist only of letters and digits");
            }

            else if (!ifMeetLenghtReq & ifHasQnlyLettersAndDigits & !ifHasMinReqDigits)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                Console.WriteLine("Password must have at least 2 digits");
            }

            else if (ifMeetLenghtReq & !ifHasQnlyLettersAndDigits & !ifHasMinReqDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                Console.WriteLine("Password must have at least 2 digits");
            }
            
            else if (!ifMeetLenghtReq & !ifHasQnlyLettersAndDigits & !ifHasMinReqDigits)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                Console.WriteLine("Password must consist only of letters and digits");
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
        static bool CheckPassLenght(string password)
        {
            if (password.Length >= 6 & password.Length <= 10)
            {
                return true;
            }
            return false;
        }

        static bool CheckForCorrectSymbols(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckMinReqDigits(string password)
        {
            int counterDigits = 0;

            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    counterDigits++;
                    if (counterDigits > 1)
                    {
                        return true;
                    } 
                }
            }
            return false;
        }
    }
}
