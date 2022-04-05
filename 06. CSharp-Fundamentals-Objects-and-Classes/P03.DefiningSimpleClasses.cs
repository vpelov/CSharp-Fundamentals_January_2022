using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.DefiningSimpleClasses
{

    class Song
    {

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<Song> allSongsCollection = new List<Song>();
            int numberSong = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberSong; i++)
            {
                Song collectionSong = new Song();

                string[] inputData = Console.ReadLine().Split('_').ToArray();

                collectionSong.TypeList = inputData[0];
                collectionSong.Name = inputData[1];
                collectionSong.Time = inputData[2];

                allSongsCollection.Add(collectionSong);
            }

            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song item in allSongsCollection)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else
            {
                for (int i = 0; i < allSongsCollection.Count; i++)
                {
                    if (command == allSongsCollection[i].TypeList)
                    {
                        Console.WriteLine(allSongsCollection[i].Name);
                    }
                }
            }


        }
    }
}
