namespace _01._Vehicles
{
    using System;

    public class StartUp
    {
        private const double CarAirCondConsumption = 0.9;
        private const double TruckAirCondConsumption = 1.6;

        public static void Main()
        {
            var car = ReadCar();
            var truck = ReadTruck();
            var numberOfCommands = int.Parse(Console.ReadLine());
            ProcessCommands(car, truck, numberOfCommands);
            PrintResult(car, truck);
        }

        private static void PrintResult(Car car, Truck truck)
        {
            Console.WriteLine(car);
            Console.WriteLine(truck);
        }

        private static void ProcessCommands(Car car, Truck truck, int numberOfCommands)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var command = commandTokens[0];
                var vehicle = commandTokens[1];

                switch (command)
                {
                    case "Drive":
                        var distance = double.Parse(commandTokens[2]);

                        if (vehicle == "Car")
                        {
                            Console.WriteLine(car.Drive(distance));
                        }
                        else
                        {
                            Console.WriteLine(truck.Drive(distance));
                        }
                        break;

                    case "Refuel":
                        var liters = double.Parse(commandTokens[2]);

                        if (vehicle == "Car")
                        {
                            car.Refuel(liters);
                        }
                        else
                        {
                            truck.Refuel(liters);
                        }
                        break;

                    default:
                        throw new ArgumentException();
                }
            }
        }

        private static Truck ReadTruck()
        {
            // "Truck {fuel quantity} {liters per km}"
            var truckInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var fuelQuantity = double.Parse(truckInfo[1]);
            var litersPerKm = double.Parse(truckInfo[2]);
            var truck = new Truck(fuelQuantity, litersPerKm, TruckAirCondConsumption);
            return truck;
        }

        private static Car ReadCar()
        {
            // "Car {fuel quantity} {liters per km}"
            var carInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var fuelQuantity = double.Parse(carInfo[1]);
            var litersPerKm = double.Parse(carInfo[2]);
            var car = new Car(fuelQuantity, litersPerKm, CarAirCondConsumption);
            return car;
        }
    }
}