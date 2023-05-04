using AutoMapper;
using Factions.Application.Common.Models;
using Factions.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factions.Application.MappingProfile
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Faction,FactionDto>().ReverseMap();
        }
    }
}
