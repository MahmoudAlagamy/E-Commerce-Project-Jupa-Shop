using AutoMapper;
using JupaShopGraduationProject.DAL.Entities;
using JupaShopGraduationProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JupaShopGraduationProject.BL.Mapper
{
    public class DomainProfile : Profile
    {
        public DomainProfile()
        {
            // Mapper for Mobiles
            CreateMap<Mobiles, MobilesVM>();
            CreateMap<MobilesVM, Mobiles>();
        }
    }
}
