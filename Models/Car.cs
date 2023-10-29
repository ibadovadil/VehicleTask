namespace VehicleTask.Models
{
    internal class Car : Vehicle, IEngine, IWheel, ITransmission
    {
        public int DoorCount { get; set; }
        public string WinCode { get; set; }

        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public double WheelThickness { get; set; }
        public string TransmissionKind { get; set; }



        public override void GetAllInfo()
        {
            Console.WriteLine("Car Information:");
            Console.WriteLine($"Door Count: {DoorCount}");
            Console.WriteLine($"VIN Code: {WinCode}");
            Console.WriteLine($"Horse Power: {HorsePower}");
            Console.WriteLine($"Tank Size: {TankSize}");
            Console.WriteLine($"Current Oil: {CurrentOil}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Wheel Thickness: {WheelThickness}");
            Console.WriteLine($"Transmission Kind: {TransmissionKind}");
            Console.WriteLine($"Drive Time: {DriveTime}");
            Console.WriteLine($"Drive Path: {DrivePath}");
        }
    }
}
