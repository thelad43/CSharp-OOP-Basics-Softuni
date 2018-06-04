namespace _14._Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var cats = ReadCats();
            PrintCat(cats);
        }

        private static void PrintCat(List<Cat> cats)
        {
            var catName = Console.ReadLine();
            var catToPrint = cats.FirstOrDefault(c => c.Name == catName);
            Console.WriteLine(catToPrint);
        }

        private static List<Cat> ReadCats()
        {
            var cats = new List<Cat>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "End")
                {
                    break;
                }

                var catInfo = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var cat = new Cat
                {
                    Breed = catInfo[0],
                    Name = catInfo[1]
                };

                if (cat.Breed == "Siamese")
                {
                    cat.EarSize = int.Parse(catInfo[2]);
                }
                else if (cat.Breed == "Cymric")
                {
                    cat.FurLength = double.Parse(catInfo[2]);
                }
                else if (cat.Breed == "StreetExtraordinaire")
                {
                    cat.DecibelsOfMeows = int.Parse(catInfo[2]);
                }

                cats.Add(cat);
            }

            return cats;
        }
    }
}