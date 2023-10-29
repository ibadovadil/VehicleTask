namespace VehicleTask.Models
{
    public abstract class Vehicle
    {
        public double DriveTime { get; set; }
        public string DrivePath { get; set; }


        public abstract void GetAllInfo();
    }
}
