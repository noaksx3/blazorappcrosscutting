using BlazorApp1.Core.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Extensions
{
    public static class ContainerExtensions
    {
        public static void AddBlazorApp1(this IServiceCollection services)
        {
            services.AddBlazorApp1Core();
        }
    }
}
