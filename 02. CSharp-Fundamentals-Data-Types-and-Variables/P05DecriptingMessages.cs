using System;

namespace P05DecriptingMessages
{
    internal class P05DecriptingMessages
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberSymbol = int.Parse(Console.ReadLine());

            string messages = string.Empty;

            for (int i = 0; i < numberSymbol; i++)
            {
                char currentCh = char.Parse(Console.ReadLine());
                int chAdd = currentCh + key;
                messages += Convert.ToChar(chAdd);
                //Console.WriteLine(currentCh + key);
            }

            Console.WriteLine(messages);
        }
    }
}
