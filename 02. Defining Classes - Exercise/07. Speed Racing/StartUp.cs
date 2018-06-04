namespace _07._Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var cars = ReadInputCars(n);

            PrintCars(cars);
        }

        private static List<Car> ReadInputCars(int n)
        {
            var cars = new List<Car>(n);

            for (int i = 0; i < n; i++)
            {
                // <Model> <FuelAmount> <FuelConsumptionFor1km>
                var carTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var model = carTokens[0];
                var fuelAmount = double.Parse(carTokens[1]);
                var fuelConsumptionPerKm = double.Parse(carTokens[2]);

                var car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                cars.Add(car);
            }

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                // Drive <CarModel>  <amountOfKm>
                var carArguments = line
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var carModel = carArguments[1];
                var amountOfKm = double.Parse(carArguments[2]);

                var car = cars.Single(c => c.Model == carModel);

                try
                {
                    if (car.CanMoveDistance(amountOfKm))
                    {
                        var usedFuel = car.CalclulateUsedFuel(amountOfKm);
                        car.FuelAmount -= usedFuel;
                        car.DistanceTraveled += amountOfKm;
                    }
                    else
                    {
                        throw new InvalidOperationException("Insufficient fuel for the drive");
                    }
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return cars;
        }

        private static void PrintCars(List<Car> cars)
        {
            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }
}