namespace VehicleTask.Models
{
    public class Plane : Vehicle, IEngine, ITransmission
    {
        public double WingLength { get; set; }

        public int HorsePower { get; set; }
        public double TankSize { get; set; }
        public double CurrentOil { get; set; }
        public string FuelType { get; set; }
        public string TransmissionKind { get; set; }



        public override void GetAllInfo()
        {
            Console.WriteLine("Plane Information:");
            Console.WriteLine($"Wing Length: {WingLength}");
            Console.WriteLine($"Horse Power: {HorsePower}");
            Console.WriteLine($"Tank Size: {TankSize}");
            Console.WriteLine($"Current Oil: {CurrentOil}");
            Console.WriteLine($"Fuel Type: {FuelType}");
            Console.WriteLine($"Transmission Kind: {TransmissionKind}");
            Console.WriteLine($"Drive Time: {DriveTime}");
            Console.WriteLine($"Drive Path: {DrivePath}");
        }
    }
}
