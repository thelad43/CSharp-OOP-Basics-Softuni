namespace _04._Shopping_Spree
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            var people = ReadPeople();
            var products = ReadProducts();
            ProcessBuyingProducts(people, products);
        }

        private static void ProcessBuyingProducts(List<Person> people, List<Product> products)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "END")
                {
                    break;
                }

                var personProduct = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var person = people.SingleOrDefault(p => p.Name == personProduct[0]);
                var product = products.SingleOrDefault(p => p.Name == personProduct[1]);

                try
                {
                    TryPersonBuyProduct(person, product);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            PrintPeople(people);
        }

        private static void PrintPeople(List<Person> people)
        {
            var stringBuilder = new StringBuilder();

            foreach (var person in people)
            {
                stringBuilder.Append(person.Name);
                stringBuilder.Append(" - ");

                if (!person.Products.Any())
                {
                    stringBuilder.Append("Nothing bought");
                }

                stringBuilder.AppendLine(string.Join(", ", person.Products.Select(p => p.Name)));
            }

            Console.WriteLine(stringBuilder);
        }

        private static void TryPersonBuyProduct(Person person, Product product)
        {
            if (person.Money >= product.Price)
            {
                person.Products.Add(product);
                person.Money -= product.Price;
                Console.WriteLine($"{person.Name} bought {product.Name}");
                return;
            }

            throw new InvalidOperationException($"{person.Name} can't afford {product.Name}");
        }

        private static List<Product> ReadProducts()
        {
            var products = new List<Product>();

            var productsPrices = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < productsPrices.Length; i++)
            {
                var productTokens = productsPrices[i]
                    .Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = productTokens[0];
                var price = decimal.Parse(productTokens[1]);

                Product product = null;

                try
                {
                    product = new Product(name, price);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }

                products.Add(product);
            }

            return products;
        }

        private static List<Person> ReadPeople()
        {
            var people = new List<Person>();

            var peopleMoney = Console.ReadLine()
                .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < peopleMoney.Length; i++)
            {
                var personTokens = peopleMoney[i]
                    .Split(new char[] { '=' }, StringSplitOptions.RemoveEmptyEntries);

                var name = personTokens[0];
                var money = decimal.Parse(personTokens[1]);

                Person person = null;

                try
                {
                    person = new Person(name, money);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                    Environment.Exit(0);
                }

                people.Add(person);
            }

            return people;
        }
    }
}