using BlazorApp1.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.ViewModels
{
    public class CreateVehicleViewModel : IVehicle
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public int Mileage { get; set; }
        public string Model { get; set; }
        public int VehicleTypeId { get; set; }
        public int Year { get; set; }

        public CreateVehicleViewModel(int year, string make, string model, int mileage)
        {
            Year = year;
            Make = make;
            Model = model;
            Mileage = mileage;
        }
    }
}
