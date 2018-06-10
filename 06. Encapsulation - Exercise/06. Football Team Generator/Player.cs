namespace _06._Football_Team_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        private string name;
        private string[] statsNames = new string[] { "Endurance", "Sprint", "Dribble", "Passing", "Shooting" };
        private List<int> stats;

        public Player(string name)
        {
            this.Name = name;
            this.Stats = new List<int>();
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

        public List<int> Stats
        {
            get
            {
                return this.stats;
            }
            private set
            {
                this.stats = value;
            }
        }

        internal void AddStats(params int[] stats)
        {
            for (int i = 0; i < stats.Length; i++)
            {
                if (stats[i] < 0 || stats[i] > 100)
                {
                    throw new ArgumentException($"{this.statsNames[i]} should be between 0 and 100.");
                }
            }

            this.Stats.AddRange(stats);
        }

        internal double OverallSkillLevel()
        {
            return this.Stats.Average();
        }
    }
}