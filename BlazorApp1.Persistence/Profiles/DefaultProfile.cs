using AutoMapper;

using BlazorApp1.Core.Models;
using BlazorApp1.Data.Entities;

namespace BlazorApp1.Core.Profiles
{
    internal class DefaultProfile : Profile
    {
        public DefaultProfile()
        {
            CreateMap<IVehicle, Vehicle>()
                .ReverseMap();
        }
    }
}
