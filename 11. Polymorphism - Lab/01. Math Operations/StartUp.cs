namespace _01._Math_Operations
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var mathOperation = new MathOperation();
            Console.WriteLine(mathOperation.Add(2, 3));
            Console.WriteLine(mathOperation.Add(2.2, 3.3, 5.5));
            Console.WriteLine(mathOperation.Add(2.2m, 3.3m, 4.4m));
        }
    }
}