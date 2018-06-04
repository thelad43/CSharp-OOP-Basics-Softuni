namespace _12._Google
{
    public class Company
    {
        public Company()
        {
        }

        public Company(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;
        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Department} {this.Salary:F2}";
        }
    }
}