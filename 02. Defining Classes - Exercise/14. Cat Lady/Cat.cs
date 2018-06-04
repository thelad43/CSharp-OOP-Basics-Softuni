namespace _14._Cat_Lady
{
    public class Cat
    {
        public Cat()
        {
        }

        public Cat(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public string Breed { get; set; }

        public int EarSize { get; set; }

        public int DecibelsOfMeows { get; set; }

        public double FurLength { get; set; }

        public override string ToString()
        {
            if (this.Breed == "Siamese")
            {
                return $"{this.Breed} {this.Name} {this.EarSize}";
            }
            else if (this.Breed == "Cymric")
            {
                return $"{this.Breed} {this.Name} {this.FurLength:F2}";
            }
            else if (this.Breed == "StreetExtraordinaire")
            {
                return $"{this.Breed} {this.Name} {this.DecibelsOfMeows}";
            }

            return null;
        }
    }
}