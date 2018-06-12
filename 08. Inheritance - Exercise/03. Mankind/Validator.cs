namespace _03._Mankind
{
    using System;

    public static class Validator
    {
        private const int MinHours = 1;
        private const int MaxHours = 12;
        private const decimal MinWeekSalary = 11.0M;
        private const int HumanFirstNameMinLength = 4;
        private const int HumanLastNameMinLength = 3;
        private const int FacultyNumberMinLength = 5;
        private const int FacultyNumberMaxLength = 10;

        public static void ValidateFirstName(string firstName)
        {
            if (char.IsLower(firstName[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(firstName)}");
            }

            if (firstName.Length < HumanFirstNameMinLength)
            {
                throw new ArgumentException($"Expected length at least {HumanFirstNameMinLength} symbols! Argument: {nameof(firstName)}");
            }
        }

        public static void ValidateLastName(string lastName)
        {
            if (char.IsLower(lastName[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(lastName)}");
            }

            if (lastName.Length < HumanLastNameMinLength)
            {
                throw new ArgumentException($"Expected length at least {HumanLastNameMinLength} symbols! Argument: {nameof(lastName)}");
            }
        }

        public static void ValidateFacultyNumber(string facultyNumber)
        {
            if (!(facultyNumber.Length >= FacultyNumberMinLength && facultyNumber.Length <= FacultyNumberMaxLength))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
        }

        public static void ValidateWeekSalary(decimal weekSalary)
        {
            if (weekSalary <= MinWeekSalary)
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(weekSalary)}");
            }
        }

        public static void ValidateWorkingHours(int workHoursPerDay)
        {
            if (!(workHoursPerDay >= MinHours && workHoursPerDay <= MaxHours))
            {
                throw new ArgumentException($"Expected value mismatch! Argument: {nameof(workHoursPerDay)}");
            }
        }
    }
}