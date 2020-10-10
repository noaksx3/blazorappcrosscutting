using BlazorApp1.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Data.Entities;

namespace BlazorApp1.Core.Services
{
    internal class InMemoryVehicleService : IVehicleService
    {
        private readonly IDbContextFactory<BlazorAppDbContext> _dbContextFactory;
        private readonly IMapper _mapper;
        public InMemoryVehicleService(IDbContextFactory<BlazorAppDbContext> dbContextFactory, IMapper mapper)
        {
            _dbContextFactory = dbContextFactory;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            var entity = dbContext.Vehicles.Find(id);

            if(entity != null)
            {
                dbContext.Remove(entity);
                dbContext.SaveChanges();
            }

        }

        public IVehicle GetVehicle(int id)
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            var entity = dbContext.Vehicles.Find(id);

            return _mapper.Map<IVehicle>(entity);
        }

        public IEnumerable<IVehicle> GetVehicles()
        {
            using var dbContext = _dbContextFactory.CreateDbContext();

            var entities = dbContext.Vehicles;

            return _mapper.Map<IVehicle[]>(entities);
        }

        public IVehicle Save(IVehicle model)
        {
            var entity = _mapper.Map<Vehicle>(model);

            using var dbContext = _dbContextFactory.CreateDbContext();

            dbContext.Entry(entity).State = EntityState.Added;

            dbContext.SaveChanges();

            return _mapper.Map<IVehicle>(entity);
        }
    }
}
