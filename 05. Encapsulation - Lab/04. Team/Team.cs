namespace _04._Team
{
    using System.Collections.Generic;

    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public List<Person> FirstTeam { get; } = new List<Person>();

        public List<Person> ReserveTeam { get; } = new List<Person>();

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.FirstTeam.Add(person);
            }
            else
            {
                this.ReserveTeam.Add(person);
            }
        }
    }
}