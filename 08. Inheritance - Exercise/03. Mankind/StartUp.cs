namespace _03._Mankind
{
    using Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            try
            {
                var student = ReadStudent();
                var worker = ReadWorker();

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        private static Worker ReadWorker()
        {
            var workerInfo = Console.ReadLine().Split();

            var workerFirstName = workerInfo[0];
            var workerLastName = workerInfo[1];
            var weekSalary = decimal.Parse(workerInfo[2]);
            var workingHoursPerDay = int.Parse(workerInfo[3]);

            var worker = new Worker(workerFirstName, workerLastName, weekSalary, workingHoursPerDay);
            return worker;
        }

        private static Student ReadStudent()
        {
            var studentInfo = Console.ReadLine().Split();

            var studentFirstName = studentInfo[0];
            var studentLastName = studentInfo[1];
            var facultyNumber = studentInfo[2];

            var student = new Student(studentFirstName, studentLastName, facultyNumber);
            return student;
        }
    }
}