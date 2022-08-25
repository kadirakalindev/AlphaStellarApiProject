using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configs.Mapper
{
    public  class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<CarColorDto, Car>();
            CreateMap<CarLightsDTO, Car>();
        }
    }
}
