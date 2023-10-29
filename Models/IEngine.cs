namespace VehicleTask.Models
{
    public interface IEngine
    {
        int HorsePower { get; set; }
        double TankSize { get; set; }
        double CurrentOil { get; set; }
        string FuelType { get; set; }


    }

}
