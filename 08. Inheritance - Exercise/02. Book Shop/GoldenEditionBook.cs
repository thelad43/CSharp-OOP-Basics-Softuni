namespace _02._Book_Shop
{
    public class GoldenEditionBook : Book
    {
        private const decimal PercantagesOfPriceGoldenBook = 0.3M;

        public GoldenEditionBook(string title, string author, decimal price)
            : base(title, author, price)
        {
            this.Price = price;
        }

        public new decimal Price
        {
            get
            {
                return base.Price;
            }
            set
            {
                var price = value + (value * PercantagesOfPriceGoldenBook);
                base.Price = price;
            }
        }
    }
}