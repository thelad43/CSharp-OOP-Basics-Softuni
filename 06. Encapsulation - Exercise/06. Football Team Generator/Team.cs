namespace _06._Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private HashSet<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new HashSet<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public int Rating
        {
            get
            {
                return this.CalculateRating();
            }
        }

        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            if (this == null)
            {
                throw new NullReferenceException("Team does not existent");
            }

            if (this.players.Any(p => p.Name == playerName))
            {
                this.players.RemoveWhere(p => p.Name == playerName);
            }
            else
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
        }

        private int CalculateRating()
        {
            var rating = 0D;

            foreach (var player in this.players)
            {
                rating += player.OverallSkillLevel();
            }

            rating /= this.players.Count;
            rating = double.IsNaN(rating) ? 0 : rating;
            return (int)Math.Round(rating);
        }
    }
}