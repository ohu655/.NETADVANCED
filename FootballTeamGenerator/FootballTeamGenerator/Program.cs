using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                string[] parts = line.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string command = parts[0];

                try
                {
                    if (command == "Team")
                    {
                        string teamName = parts[1];
                        Team team = new Team(teamName);
                        teams.Add(teamName, team);
                    }
                    else if (command == "Add")
                    {
                        string teamName = parts[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        string playerName = parts[2];
                        int endurance = int.Parse(parts[3]);
                        int sprint = int.Parse(parts[4]);
                        int dribble = int.Parse(parts[5]);
                        int passing = int.Parse(parts[6]);
                        int shooting = int.Parse(parts[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);

                        teams[teamName].AddPlayer(player);

                    }
                    else if (command == "Remove")
                    {
                        string teamName = parts[1];
                        string playerName = parts[2];

                        teams[teamName].RemovePlayer(playerName);

                    }
                    else if (command == "Rating")
                    {
                        string teamName = parts[1];

                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                        }
                        else
                        {
                            Console.WriteLine($"{teamName} - {teams[teamName].Rating}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
