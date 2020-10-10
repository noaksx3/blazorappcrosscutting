using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("BlazorApp1.Core")]
namespace BlazorApp1.Data.Entities
{
    internal class BlazorAppDbContext : DbContext
    {
        public BlazorAppDbContext(DbContextOptions<BlazorAppDbContext> options) : base(options)
        {

        }

        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
