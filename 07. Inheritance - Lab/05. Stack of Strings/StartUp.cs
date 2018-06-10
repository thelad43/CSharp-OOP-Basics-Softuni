namespace _05._Stack_of_Strings
{
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var stackOfStrings = new StackOfStrings();

            stackOfStrings.Push("aaa");
            stackOfStrings.Push("bbb");
            stackOfStrings.Push("ccc");
            stackOfStrings.Push("ddd");
            stackOfStrings.Push("eee");
            stackOfStrings.Push("fff");

            Console.Write("Elements in the StackOfStrings: ");
            PrintStackOfStrings(stackOfStrings);

            var removed = stackOfStrings.Pop();
            Console.WriteLine($"After removing element {removed}");
            PrintStackOfStrings(stackOfStrings);

            removed = stackOfStrings.Pop();
            Console.WriteLine($"After removing element: {removed}");
            PrintStackOfStrings(stackOfStrings);

            var peekElement = stackOfStrings.Peek();
            Console.WriteLine($"Peeked element: {peekElement}");
            Console.Write("Elements in the StackOfStrings: ");
            PrintStackOfStrings(stackOfStrings);

            stackOfStrings.Pop();
            stackOfStrings.Pop();
            stackOfStrings.Pop();

            Console.WriteLine(stackOfStrings.IsEmpty());
            PrintStackOfStrings(stackOfStrings);

            stackOfStrings.Pop();

            Console.WriteLine(stackOfStrings.IsEmpty());
            PrintStackOfStrings(stackOfStrings);
        }

        private static void PrintStackOfStrings(StackOfStrings stackOfStrings)
        {
            var stringBuilder = new StringBuilder();

            foreach (var element in stackOfStrings)
            {
                stringBuilder.Append($"{element} ");
            }

            stringBuilder.ToString().Trim();
            Console.WriteLine(stringBuilder);
        }
    }
}