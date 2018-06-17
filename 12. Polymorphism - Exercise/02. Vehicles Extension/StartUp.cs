namespace _02._Vehicles_Extension
{
    using Models;
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var car = ReadCar();
            var truck = ReadTruck();
            var bus = ReadBus();

            var numberOfCommands = int.Parse(Console.ReadLine());

            ProcessCommands(car, truck, bus, numberOfCommands);
            PrintResult(car, truck, bus);
        }

        private static void PrintResult(Car car, Truck truck, Bus bus)
        {
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }

        private static void ProcessCommands(Car car, Truck truck, Bus bus, int numberOfCommands)
        {
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commandTokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var command = commandTokens[0];
                var vehicle = commandTokens[1];

                try
                {
                    switch (command)
                    {
                        case "Drive":
                            var distance = double.Parse(commandTokens[2]);

                            if (vehicle == "Car")
                            {
                                car.Drive(distance);
                            }
                            else if (vehicle == "Truck")
                            {
                                truck.Drive(distance);
                            }
                            else
                            {
                                bus.Drive(distance);
                            }
                            break;

                        case "Refuel":
                            var liters = double.Parse(commandTokens[2]);

                            if (vehicle == "Car")
                            {
                                car.Refuel(liters);
                            }
                            else if (vehicle == "Truck")
                            {
                                truck.Refuel(liters);
                            }
                            else
                            {
                                bus.Refuel(liters);
                            }
                            break;

                        case "DriveEmpty":
                            distance = double.Parse(commandTokens[2]);
                            bus.Drive(distance);
                            break;

                        default:
                            throw new ArgumentException("Invalid command");
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        private static Bus ReadBus()
        {
            // "Bus {initial fuel quantity} {liters per km} {tank capacity}"
            var busInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var initialFuelQuantity = double.Parse(busInfo[1]);
            var litersPerKm = double.Parse(busInfo[2]);
            var tankCapacity = double.Parse(busInfo[3]);
            var bus = new Bus(initialFuelQuantity, litersPerKm, tankCapacity);
            return bus;
        }

        private static Truck ReadTruck()
        {
            // "Truck {initial fuel quantity} {liters per km} {tank capacity}"
            var truckInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var fuelQuantity = double.Parse(truckInfo[1]);
            var litersPerKm = double.Parse(truckInfo[2]);
            var tankCapacity = double.Parse(truckInfo[3]);
            var truck = new Truck(fuelQuantity, litersPerKm, tankCapacity);
            return truck;
        }

        private static Car ReadCar()
        {
            // "Car {initial fuel quantity} {liters per km} {tank capacity}"
            var carInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            var fuelQuantity = double.Parse(carInfo[1]);
            var litersPerKm = double.Parse(carInfo[2]);
            var tankCapacity = double.Parse(carInfo[3]);
            var car = new Car(fuelQuantity, litersPerKm, tankCapacity);
            return car;
        }
    }
}