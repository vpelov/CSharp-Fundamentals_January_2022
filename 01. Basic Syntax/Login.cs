using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string reversUsername = string.Empty;
            int lenghtPass = username.Length;

            int count = 0;
            bool correctPass = true;


            for (int i = lenghtPass - 1; i >= 0; i--)
            {
                reversUsername = reversUsername + username[i];
            }

            string pass = Console.ReadLine();

            if (pass == reversUsername)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {

                while (pass != reversUsername)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    count++;
                    if (count >= 3)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        correctPass = false;
                        break;
                    }
                    pass = Console.ReadLine();
                }

                if (correctPass)
                {
                Console.WriteLine($"User {username} logged in.");
                }

            }

        }
    }
}
