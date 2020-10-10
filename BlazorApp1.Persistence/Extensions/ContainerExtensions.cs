using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BlazorApp1.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.Configuration;

namespace BlazorApp1.Data.Extensions
{
    public static class ContainerExtensions
    {
        public static void AddBlazor1AppData(this IServiceCollection services)
        {
            services.AddDbContextFactory<BlazorAppDbContext>(options => options.UseInMemoryDatabase("VehicleDatabase"));
        }
    }
}
