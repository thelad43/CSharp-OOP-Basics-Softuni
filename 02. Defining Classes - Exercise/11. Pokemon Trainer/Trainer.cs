namespace _11._Pokemon_Trainer
{
    using System.Collections.Generic;
    using System.Linq;

    public class Trainer
    {
        public Trainer()
        {
        }

        public Trainer(string name, int numberOfBadges = 0)
        {
            this.Name = name;
            this.NumberOfBadges = numberOfBadges;
            this.Pokemons = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int NumberOfBadges { get; set; }

        public List<Pokemon> Pokemons { get; set; }

        internal void ClearDeadPokemons()
        {
            if (this.Pokemons.Count > 0 && this.Pokemons.Where(p => p.Health <= 0).FirstOrDefault() != null)
            {
                this.Pokemons = new List<Pokemon>(this.Pokemons.Where(p => p.Health > 0));
            }
        }
    }
}