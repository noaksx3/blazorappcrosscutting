using BlazorApp1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorApp1.Core.Services
{
    public interface IVehicleService
    {
        IEnumerable<IVehicle> GetVehicles();
        IVehicle GetVehicle(int id);
        IVehicle Save(IVehicle model);
        void Delete(int id);
    }
}
