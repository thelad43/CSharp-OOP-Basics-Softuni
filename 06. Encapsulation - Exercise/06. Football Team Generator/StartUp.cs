namespace _06._Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var teams = new List<Team>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "END")
                {
                    break;
                }

                var commandTokens = inputLine
                    .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                ProcessCommand(commandTokens, teams);
            }
        }

        private static void ProcessCommand(string[] commandTokens, List<Team> teams)
        {
            var command = commandTokens[0];

            switch (command)
            {
                // Add Team
                case "Team":
                    AddTeam(commandTokens, teams);
                    break;

                // Add Player to given team
                case "Add":
                    AddPlayer(commandTokens, teams);
                    break;

                // Remove given player from team
                case "Remove":
                    RemovePlayer(commandTokens, teams);
                    break;

                // Show Rating
                case "Rating":
                    ShowRating(commandTokens, teams);
                    break;

                default:
                    throw new ArgumentException();
            }
        }

        private static void ShowRating(string[] commandTokens, List<Team> teams)
        {
            var teamName = commandTokens[1];
            Team team = null;

            try
            {
                team = teams.Single(t => t.Name == teamName);
                Console.WriteLine($"{teamName} - {team.Rating}");
            }
            catch
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
        }

        private static void RemovePlayer(string[] commandTokens, List<Team> teams)
        {
            var teamName = commandTokens[1];
            var playerName = commandTokens[2];

            try
            {
                var team = teams.Single(t => t.Name == teamName);
                team.RemovePlayer(playerName);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine(nre.Message);
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }
            catch (Exception)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
        }

        private static void AddPlayer(string[] commandTokens, List<Team> teams)
        {
            var teamName = commandTokens[1];
            var playerName = commandTokens[2];

            // Player Stats
            var endurance = int.Parse(commandTokens[3]);
            var sprint = int.Parse(commandTokens[4]);
            var dribble = int.Parse(commandTokens[5]);
            var passing = int.Parse(commandTokens[6]);
            var shooting = int.Parse(commandTokens[7]);

            Team team = null;

            try
            {
                team = teams.Single(t => t.Name == teamName);
                var player = new Player(playerName);
                player.AddStats(endurance, sprint, dribble, passing, shooting);
                team.AddPlayer(player);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
        }

        private static void AddTeam(string[] commandTokens, List<Team> teams)
        {
            var name = commandTokens[1];
            var team = new Team(name);
            teams.Add(team);
        }
    }
}