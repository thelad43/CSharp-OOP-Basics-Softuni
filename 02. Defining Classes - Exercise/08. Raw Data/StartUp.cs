namespace _08._Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        private const int tiresCount = 4;

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var cars = ReadCars(n);

            var command = Console.ReadLine();

            List<Car> result;

            if (command == "fragile")
            {
                // Print all cars whose Cargo Type is "fragil" with a tire whose pressure is  < 1

                result = ProcessCarsWithTypeFragile(cars);

                PrintCars(result);
            }
            else if (command == "flamable")
            {
                // Print all cars whose Cargo Type is "flamable" and have Engine Power > 250

                result = ProcessCarsWithTypeFlamable(cars);

                PrintCars(result);
            }
        }

        private static void PrintCars(List<Car> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars.Select(c => c.Model)));
        }

        private static List<Car> ProcessCarsWithTypeFlamable(List<Car> cars)
        {
            var carsWithTypeFlamable = cars.Where(c => c.Cargo.CargoType == "flamable").ToArray();
            var carsWithEnginePowerMoreThan250 = new List<Car>();

            foreach (var car in carsWithTypeFlamable)
            {
                if (car.Engine.EnginePower > 250)
                {
                    carsWithEnginePowerMoreThan250.Add(car);
                }
            }

            return carsWithEnginePowerMoreThan250;
        }

        private static List<Car> ProcessCarsWithTypeFragile(List<Car> cars)
        {
            var carsWithTypeFragile = cars.Where(c => c.Cargo.CargoType == "fragile").ToArray();
            var carsWithTirePressureLessThanOne = new List<Car>();

            foreach (var car in carsWithTypeFragile)
            {
                var tires = car.Tires;

                for (int i = 0; i < tires.Count; i++)
                {
                    if (tires[i].TirePressure < 1)
                    {
                        carsWithTirePressureLessThanOne.Add(car);
                        break;
                    }
                }
            }

            return carsWithTirePressureLessThanOne;
        }

        private static List<Car> ReadCars(int n)
        {
            var cars = new List<Car>(n);

            for (int i = 0; i < n; i++)
            {
                // <Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>
                var carTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                // Engine
                var engineSpeed = int.Parse(carTokens[1]);
                var enginePower = int.Parse(carTokens[2]);
                var engine = new Engine(engineSpeed, enginePower);

                // Cargo
                var cargoWeight = int.Parse(carTokens[3]);
                var cargoType = carTokens[4];
                var cargo = new Cargo(cargoWeight, cargoType);

                // Tires
                var tires = new List<Tire>(tiresCount);
                var tyre1Pressure = double.Parse(carTokens[5]);
                var tyre1Age = int.Parse(carTokens[6]);
                var tyre2Pressure = double.Parse(carTokens[7]);
                var tyre2Age = int.Parse(carTokens[8]);
                var tyre3Pressure = double.Parse(carTokens[9]);
                var tyre3Age = int.Parse(carTokens[10]);
                var tyre4Pressure = double.Parse(carTokens[11]);
                var tyre4Age = int.Parse(carTokens[12]);

                tires.Add(new Tire(tyre1Pressure, tyre1Age));
                tires.Add(new Tire(tyre2Pressure, tyre2Age));
                tires.Add(new Tire(tyre3Pressure, tyre3Age));
                tires.Add(new Tire(tyre4Pressure, tyre4Age));

                // Car
                var model = carTokens[0];
                var car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            return cars;
        }
    }
}