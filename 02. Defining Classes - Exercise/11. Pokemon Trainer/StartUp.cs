namespace _11._Pokemon_Trainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var trainers = ReadTrainers();

            ProcessElements(trainers);

            PrintTrainers(trainers);
        }

        private static void PrintTrainers(Queue<Trainer> trainers)
        {
            var result = trainers
                .OrderByDescending(t => t.NumberOfBadges)
                .Select(t => $"{t.Name} {t.NumberOfBadges} {t.Pokemons.Count}")
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void ProcessElements(Queue<Trainer> trainers)
        {
            while (true)
            {
                var element = Console.ReadLine();

                if (element == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    if (trainer.Pokemons.Where(p => p.Element == element).FirstOrDefault() == null)
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.ReduceHealth();
                        }

                        trainer.ClearDeadPokemons();
                    }
                    else
                    {
                        trainer.NumberOfBadges++;
                    }
                }
            }
        }

        private static Queue<Trainer> ReadTrainers()
        {
            var trainers = new Queue<Trainer>();

            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Tournament")
                {
                    break;
                }

                // <TrainerName> <PokemonName> <PokemonElement> <PokemonHealth>
                var pokemonAndTrainerInfo = inputLine
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                var trainerName = pokemonAndTrainerInfo[0];
                var pokemonName = pokemonAndTrainerInfo[1];
                var pokemonElement = pokemonAndTrainerInfo[2];
                var pokemonHealth = int.Parse(pokemonAndTrainerInfo[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                var trainer = trainers.Where(t => t.Name == trainerName)
                    .FirstOrDefault();

                if (trainer == null)
                {
                    trainer = new Trainer(trainerName);
                }

                if (!trainers.Contains(trainer))
                {
                    trainers.Enqueue(trainer);
                }

                trainer.Pokemons.Add(pokemon);
            }

            return trainers;
        }
    }
}