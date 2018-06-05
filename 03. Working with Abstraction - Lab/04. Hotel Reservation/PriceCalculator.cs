namespace _04._Hotel_Reservation
{
    public class PriceCalculator
    {
        private decimal pricePerDay;
        private int numberOfDays;
        private Season season;
        private DiscountType discountType;

        public PriceCalculator()
        {
        }

        public PriceCalculator(decimal pricePerDay, int numberOfDays, Season season, DiscountType discountType)
        {
            this.PricePerDay = pricePerDay;
            this.NumberOfDays = numberOfDays;
            this.Season = season;
            this.DiscountType = discountType;
        }

        public decimal PricePerDay
        {
            get
            {
                return this.pricePerDay;
            }
            set
            {
                this.pricePerDay = value;
            }
        }

        public int NumberOfDays
        {
            get
            {
                return this.numberOfDays;
            }
            set
            {
                this.numberOfDays = value;
            }
        }

        public Season Season
        {
            get
            {
                return this.season;
            }
            set
            {
                this.season = value;
            }
        }

        public DiscountType DiscountType
        {
            get
            {
                return this.discountType;
            }
            set
            {
                this.discountType = value;
            }
        }

        public decimal CalculateTotalPrice()
        {
            var pricePerDay = this.PricePerDay * (int)this.Season;
            var price = pricePerDay * this.NumberOfDays;
            decimal totalPrice;

            if (this.DiscountType == DiscountType.None)
            {
                totalPrice = price;
            }
            else
            {
                totalPrice = price - (price * (int)this.DiscountType * 0.01M);
            }

            return totalPrice;
        }
    }
}