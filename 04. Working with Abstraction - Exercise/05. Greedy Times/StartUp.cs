namespace _05._Greedy_Times
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var allCapacity = long.Parse(Console.ReadLine());

            var book = new Dictionary<string, List<Ruby>>
            {
                ["Gold"] = new List<Ruby>(),
                ["Gem"] = new List<Ruby>(),
                ["Cash"] = new List<Ruby>()
            };

            var inputTokens = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputTokens.Length; i += 2)
            {
                var name = inputTokens[i].ToUpper();
                var money = long.Parse(inputTokens[i + 1]);

                var bagCount = book["Gold"].Sum(a => a.Money) +
                    book["Gem"].Sum(a => a.Money) +
                    book["Cash"].Sum(a => a.Money);

                if (allCapacity < bagCount + money)
                {
                    continue;
                }

                if (name == "GOLD")
                {
                    if (book["Gold"].All(a => a.UpperName != name))
                    {
                        var currentItem = new Ruby
                        {
                            UpperName = name,
                            NormalName = inputTokens[i],
                            Money = money
                        };

                        book["Gold"].Add(currentItem);
                    }
                    else
                    {
                        foreach (var item in book["Gold"])
                        {
                            if (item.UpperName == name)
                            {
                                item.Money += money;
                            }
                        }
                    }
                }
                else if (name.EndsWith("GEM") && name.Length > 3)
                {
                    if (book["Gold"].Sum(a => a.Money) < book["Gem"].Sum(a => a.Money) + money)
                    {
                        continue;
                    }

                    if (book["Gem"].All(a => a.UpperName != name))
                    {
                        var currentItem = new Ruby
                        {
                            UpperName = name,
                            NormalName = inputTokens[i],
                            Money = money
                        };

                        book["Gem"].Add(currentItem);
                    }
                    else
                    {
                        foreach (var item in book["Gem"])
                        {
                            if (item.UpperName == name)
                            {
                                item.Money += money;
                            }
                        }
                    }
                }
                else if (name.Length == 3)
                {
                    if (book["Gem"].Sum(a => a.Money) < book["Cash"].Sum(a => a.Money) + money)
                    {
                        continue;
                    }

                    if (book["Cash"].All(a => a.UpperName != name))
                    {
                        var currentItem = new Ruby
                        {
                            UpperName = name,
                            NormalName = inputTokens[i],
                            Money = money
                        };

                        book["Cash"].Add(currentItem);
                    }
                    else
                    {
                        foreach (var item in book["Cash"])
                        {
                            if (item.UpperName == name)
                            {
                                item.Money += money;
                            }
                        }
                    }
                }
            }

            foreach (var kvp in book.OrderByDescending(a => a.Value.Sum(p => p.Money)))
            {
                if (kvp.Value.Sum(a => a.Money) > 1)
                {
                    Console.WriteLine($"<{kvp.Key}> ${kvp.Value.Sum(p => p.Money)}");

                    foreach (var ruby in kvp.Value.OrderByDescending(a => a.NormalName).ThenBy(a => a.Money))
                    {
                        Console.WriteLine($"##{ruby.NormalName} - {ruby.Money}");
                    }
                }
            }
        }
    }
}