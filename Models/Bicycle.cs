namespace VehicleTask.Models
{
    public class Bicycle : Vehicle, IWheel
    {
        public string PedalKind { get; set; }
        public double WheelThickness { get; set; }

        public override void GetAllInfo()
        {
            Console.WriteLine("Bicycle Information:");
            Console.WriteLine($"Pedal Kind: {PedalKind}");
            Console.WriteLine($"Wheel Thickness: {WheelThickness}");
            Console.WriteLine($"Drive Time: {DriveTime}");
            Console.WriteLine($"Drive Path: {DrivePath}");
        }
    }
}
