namespace _03._Mankind.Models
{
    using System.Text;

    public class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                Validator.ValidateFacultyNumber(value);
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"First Name: {this.FirstName}");
            stringBuilder.AppendLine($"Last Name: {this.LastName}");
            stringBuilder.AppendLine($"Faculty number: {this.FacultyNumber}");

            return stringBuilder.ToString();
        }
    }
}