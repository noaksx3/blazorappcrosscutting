namespace BlazorApp1.Core.Models
{
    public interface IVehicle
    {
        int Id { get; set; }
        string Make { get; set; }
        int Mileage { get; set; }
        string Model { get; set; }
        int VehicleTypeId { get; set; }
        int Year { get; set; }
    }
}