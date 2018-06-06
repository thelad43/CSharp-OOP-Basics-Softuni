namespace _02._Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var engines = ReadEngines();

            var cars = ReadCars(engines);

            PrintResult(cars);
        }

        private static void PrintResult(List<Car> cars)
        {
            foreach (var car in cars)
            {
                var displacement = car.Engine.Displacement == -1 ? "n/a" : car.Engine.Displacement.ToString();
                var efficiency = car.Engine.Efficiency == string.Empty ? "n/a" : car.Engine.Efficiency;
                var weight = car.Weight == -1 ? "n/a" : car.Weight.ToString();
                var color = car.Color == string.Empty ? "n/a" : car.Color;

                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {displacement}");
                Console.WriteLine($"    Efficiency: {efficiency}");
                Console.WriteLine($"  Weight: {weight}");
                Console.WriteLine($"  Color: {color}");
            }
        }

        private static List<Car> ReadCars(List<Engine> engines)
        {
            var carsCount = int.Parse(Console.ReadLine());
            var cars = new List<Car>(carsCount);

            for (int i = 0; i < carsCount; i++)
            {
                // <Model> <Engine> <Weight> <Color>
                var carInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = carInfo[0];
                var engineAsString = carInfo[1];
                var engine = engines.Where(e => e.Model == engineAsString).FirstOrDefault();
                var weight = -1;
                var color = "n/a";

                if (carInfo.Length == 3)
                {
                    if (!int.TryParse(carInfo[2], out weight))
                    {
                        color = carInfo[2]; // optional
                        weight = -1;
                    }
                }
                else if (carInfo.Length == 4)
                {
                    weight = int.Parse(carInfo[2]); // optional
                    color = carInfo[3]; // optional
                }

                var car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            return cars;
        }

        private static List<Engine> ReadEngines()
        {
            var enginesCount = int.Parse(Console.ReadLine());
            var engines = new List<Engine>(enginesCount);

            for (int i = 0; i < enginesCount; i++)
            {
                // <Model> <Power> <Displacement> <Efficiency>
                var engineInfo = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = engineInfo[0];
                var power = int.Parse(engineInfo[1]);
                var displacement = -1;
                var efficiency = "n/a";

                if (engineInfo.Length == 3)
                {
                    if (!int.TryParse(engineInfo[2], out displacement))
                    {
                        efficiency = engineInfo[2];
                        displacement = -1;
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    displacement = int.Parse(engineInfo[2]); // optional
                    efficiency = engineInfo[3]; // optional
                }

                var engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            return engines;
        }
    }
}