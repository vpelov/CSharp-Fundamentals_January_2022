using System;
using System.Linq;
using System.Text;

namespace P09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            while (inputText != "END")
            {
                Console.WriteLine(CheckPolindrome(inputText));
                inputText = Console.ReadLine();                              
            }
        }

        static bool CheckPolindrome(string text)
        {
            bool isPolindrome = true;

            char[] charArray = text.ToCharArray();            
            char[] arrRev = new char[charArray.Length];

            for (int i = 0; i < charArray.Length; i++)     //   Reverse array
            {                                                             
                    arrRev[i] = charArray[charArray.Length -1 - i];          
            }                     

            for (int i = 0; i < charArray.Length; i++)      //   Compare array
            {                
                    if (charArray[i] != arrRev[i]) 
                    {
                        isPolindrome = false;             
                    } 
            }

            return isPolindrome;    
        }

    }
}
