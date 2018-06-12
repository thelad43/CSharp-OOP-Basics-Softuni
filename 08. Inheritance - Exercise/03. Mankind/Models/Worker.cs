namespace _03._Mankind.Models
{
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursperday;
        private const int DaysInWeek = 7;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursperday = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                Validator.ValidateWeekSalary(value);
                this.weekSalary = value;
            }
        }

        public int WorkHoursperday
        {
            get
            {
                return this.workHoursperday;
            }
            set
            {
                Validator.ValidateWorkingHours(value);
                this.workHoursperday = value;
            }
        }

        private decimal GetSalaryPerHour()
        {
            var salaryPerHour = this.WeekSalary / DaysInWeek / this.WorkHoursperday;
            return salaryPerHour;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"First Name: {this.FirstName}");
            stringBuilder.AppendLine($"Last Name: {this.LastName}");
            stringBuilder.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            stringBuilder.AppendLine($"Hours per day: {this.WorkHoursperday:F2}");
            stringBuilder.AppendLine($"Salary per hour: {this.GetSalaryPerHour():F2}");

            return stringBuilder.ToString();
        }
    }
}