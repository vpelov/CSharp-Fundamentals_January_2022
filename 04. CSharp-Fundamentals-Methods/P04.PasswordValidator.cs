using System;
using System.Linq;

namespace P04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            if (CheckPasswordValid(password) == true)
            {
                Console.WriteLine("Password is valid");
            }
        }



        static bool CheckPasswordValid(string pass)
        { 
        bool isValid = true;
            if (IsNeedCharacters(pass) == false)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (CheckPasswordLettersAndDigits(pass) == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (CheckMinTwoDigits(pass) == false)
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }

            return isValid;
        }

        static bool IsNeedCharacters(string pass)
        {
            bool isCharacters = true;
            if (pass.Length < 6 || pass.Length > 10)
            {
                isCharacters = false;
            }
            return isCharacters;
        }

        static bool CheckPasswordLettersAndDigits(string pass)
        {
            bool isLettersAndDigits = true;

            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsLetterOrDigit(pass[i]) == false)
                {
                    isLettersAndDigits = false;
                }
            }
            return isLettersAndDigits;
        }

        static bool CheckMinTwoDigits(string pass)
        {
            bool isMinTwoDigit = true;
            int countDigit = 0;

            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsDigit(pass[i]) == true)
                {
                    countDigit++;
                }
            }

            if (countDigit < 2)
            {
                isMinTwoDigit = false;
            }
            return isMinTwoDigit;
        }
    }
}
