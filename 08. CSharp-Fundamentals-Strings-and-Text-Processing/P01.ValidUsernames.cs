using System;
using System.Linq;

namespace P01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();

            string[] userNameData = inputData
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < userNameData.Length; i++)
            {
                if (userNameData[i].Length < 3 || userNameData[i].Length > 16)
                {
                    continue;
                }

                char[] userName = userNameData[i].ToCharArray();
                bool isCheck = true;
                for (int j = 0; j < userName.Length; j++)
                {
                    if (!char.IsLetterOrDigit(userName[j]) && userName[j] != '-' && userName[j] != '_')
                    {
                        isCheck = false;
                        break;
                    }
                }
                if (isCheck)
                {
                    Console.WriteLine(userNameData[i]);
                }
            }


        }
    }
}
