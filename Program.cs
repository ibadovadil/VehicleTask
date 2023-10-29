using VehicleTask.Models;

namespace Taskk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[100];
            int vehicleCount = 0;

            while (true)
            {
                Console.WriteLine("1 - Create new car");
                Console.WriteLine("2 - Create new Bicycle");
                Console.WriteLine("3 - Create New Plane");
                Console.WriteLine("4 - View all vehicles");
                Console.WriteLine("0 - Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    break;
                }

                switch (choice)
                {
                    case 1:
                        vehicles[vehicleCount] = CreateCar();
                        vehicleCount++;
                        break;
                    case 2:
                        vehicles[vehicleCount] = CreateBicycle();
                        vehicleCount++;
                        break;
                    case 3:
                        vehicles[vehicleCount] = CreatePlane();
                        vehicleCount++;
                        break;
                    case 4:
                        DisplayVehicles(vehicles, vehicleCount);
                        break;
                    default:
                        Console.WriteLine("Invalid opration number entered.");
                        break;
                }
            }
        }

        static Car CreateCar()
        {
            Console.WriteLine("Door Count:");
            int doorCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("VIN Code:");
            string vinCode = Console.ReadLine();
            Console.WriteLine("Drive Time:");
            int driveTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Drive Path:");
            string drivePath = Console.ReadLine();
            Console.WriteLine("Horse Power:");
            int horsePower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tank Size:");
            int tankSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current Oil:");
            int currentOil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fuel Type:");
            string fuelType = Console.ReadLine();
            Console.WriteLine("Wheel Thickness:");
            int wheelThickness = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Transmission Kind:");
            string transmissionKind = Console.ReadLine();


            Car car = new Car
            {
                DoorCount = doorCount,
                WinCode = vinCode,
                DriveTime = driveTime,
                DrivePath = drivePath,
                HorsePower = horsePower,
                TankSize = tankSize,
                CurrentOil = 0,
                FuelType = fuelType,
                WheelThickness = wheelThickness,
                TransmissionKind = transmissionKind,
            };

            return car;
        }

        static Bicycle CreateBicycle()
        {
            Console.WriteLine("Pedal Kind:");
            string pedalKind = Console.ReadLine();
            Console.WriteLine("Drive Time:");
            int driveTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Drive Path:");
            string drivePath = Console.ReadLine();
            Console.WriteLine("Wheel Thickness:");
            int wheelThickness = Convert.ToInt32(Console.ReadLine());

            Bicycle bicycle = new Bicycle
            {
                PedalKind = pedalKind,
                DriveTime = driveTime,
                DrivePath = drivePath,
                WheelThickness = wheelThickness
            };

            return bicycle;
        }

        static Plane CreatePlane()
        {
            Console.WriteLine("Wing Length:");
            double wingLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Drive Time:");
            int driveTime = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Drive Path:");
            string drivePath = Console.ReadLine();
            Console.WriteLine("Horse Power:");
            int horsePower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tank Size:");
            int tankSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current Oil:");
            int currentOil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fuel Type:");
            string fuelType = Console.ReadLine();
            Console.WriteLine("Transmission Kind:");
            string transmissionKind = Console.ReadLine();

            Plane plane = new Plane
            {
                WingLength = wingLength,
                DriveTime = driveTime,
                DrivePath = drivePath,
                HorsePower = horsePower,
                TankSize = tankSize,
                CurrentOil = currentOil,
                FuelType = fuelType,
                TransmissionKind = transmissionKind
            };

            return plane;
        }

        static void DisplayVehicles(Vehicle[] vehicles, int count)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicles[i] != null)
                {
                    vehicles[i].GetAllInfo();
                    Console.WriteLine("--------------------");
                }
            }
            Console.WriteLine("First create vehicle");

        }
    }
}