using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

using BlazorApp1.Data.Extensions;
using AutoMapper;
using BlazorApp1.Core.Services;

namespace BlazorApp1.Core.Extensions
{
    public static class ContainerExtensions
    {
        public static void AddBlazorApp1Core(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ContainerExtensions));
            services.AddBlazor1AppData();
            services.AddTransient<IVehicleService, InMemoryVehicleService>();
        }
    }
}
