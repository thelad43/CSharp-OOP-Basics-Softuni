namespace _04._Hotel_Reservation
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var priceCalculator = ReadPriceCalculator();
            var price = priceCalculator.CalculateTotalPrice();
            Console.WriteLine($"{price:F2}");
        }

        private static PriceCalculator ReadPriceCalculator()
        {
            // <pricePerDay> <numberOfDays> <season> <discountType>
            var inputTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var pricePerDay = decimal.Parse(inputTokens[0]);
            var numberOfDays = int.Parse(inputTokens[1]);
            var season = (Season)Enum.Parse(typeof(Season), inputTokens[2]);
            DiscountType discountType;

            if (inputTokens.Length > 3)
            {
                discountType = (DiscountType)Enum.Parse(typeof(DiscountType), inputTokens[3]);
            }
            else
            {
                discountType = DiscountType.None;
            }

            var priceCalculator = new PriceCalculator(pricePerDay, numberOfDays, season, discountType);
            return priceCalculator;
        }
    }
}