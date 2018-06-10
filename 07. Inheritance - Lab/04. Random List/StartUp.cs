namespace _04._Random_List
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var words = new RandomList
            {
                "aaa",
                "bbb",
                "ccc",
                "ddd",
                "eee",
                "iii",
                "kkk",
                "qqq"
            };

            var removed = words.RandomString();

            Console.Write("Removed Item: ");
            Console.WriteLine(removed);

            Console.WriteLine();
            Console.WriteLine(new string('-', 15));
            Console.WriteLine();

            Console.Write("Left Items: ");
            Console.WriteLine(string.Join(" ", words));
        }
    }
}