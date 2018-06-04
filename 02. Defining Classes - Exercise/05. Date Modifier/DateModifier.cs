namespace _05._Date_Modifier
{
    using System;
    using System.Linq;

    public class DateModifier
    {
        public DateTime FirstDateTime { get; set; }

        public DateTime SecondDateTime { get; set; }

        public static int CalculateDifference(string firstDateAsString, string secondDateAsString)
        {
            var firstDateTokens = firstDateAsString
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var secondDateTokens = secondDateAsString
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var firstDate = new DateTime(firstDateTokens[0], firstDateTokens[1], firstDateTokens[2]);
            var secondDate = new DateTime(secondDateTokens[0], secondDateTokens[1], secondDateTokens[2]);

            var differenceDays = (firstDate - secondDate).Days;
            return differenceDays;
        }
    }
}