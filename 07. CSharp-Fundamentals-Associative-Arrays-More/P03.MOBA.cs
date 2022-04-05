using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.MOBA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerData = new Dictionary<string, Dictionary<string, int>>();
            string player = string.Empty;
            string position = string.Empty;
            int skill = 0;
            while (true)
            {
                List<string> input = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "Season")
                    break;

                if (!(input.Contains("vs")))
                {
                    player = input[0];
                    position = input[1];
                    skill = int.Parse(input[2]);

                    if (playerData.ContainsKey(player))
                    {
                        if (playerData[player].ContainsKey(position))
                        {
                            if (playerData[player][position] < skill)
                                playerData[player][position] = skill;
                        }
                        else
                            playerData[player][position] = skill;
                    }
                    else
                    {
                        Dictionary<string, int> assistDic = new Dictionary<string, int>();
                        assistDic.Add(position, skill);
                        playerData[player] = assistDic;
                    }
                }
                else
                {
                    string playerOne = input[0];
                    string playerTwo = input[2];
                    if (playerData.ContainsKey(playerOne) && playerData.ContainsKey(playerTwo))
                    {
                        string playerToRemove = "";
                        foreach (var role in playerData[playerOne])
                        {
                            foreach (var pos in playerData[playerTwo])
                            {
                                if (role.Key == pos.Key)
                                {
                                    if (playerData[playerOne].Values.Sum() > playerData[playerTwo].Values.Sum())
                                        playerToRemove = playerTwo;
                                    else if (playerData[playerOne].Values.Sum() < playerData[playerTwo].Values.Sum())
                                        playerToRemove = playerOne;
                                }
                            }
                        }
                        playerData.Remove(playerToRemove);
                    }
                }
            }
            foreach (var playa in playerData.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{playa.Key}: {playa.Value.Values.Sum()} skill");
                foreach (var pair in playa.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {pair.Key} <::> {pair.Value}");
                }
            }
        }
    }
}
