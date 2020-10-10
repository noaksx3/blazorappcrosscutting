using System;
using System.Collections.Generic;
using System.Text;
using BlazorApp1.Models;

namespace BlazorApp1.Data.Entities
{
    internal class Vehicle
    {
        public int Id { get; set; }
        public VehicleType VehicleTypeId { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
    }
}
