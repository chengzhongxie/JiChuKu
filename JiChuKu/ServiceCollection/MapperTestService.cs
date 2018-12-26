using AutoMapper;
using DAL.Dtos;
using DAL.Model;
using JiChuKu.Models;
using System;

namespace JiChuKu.ServiceCollection
{
    public class MapperTestService : Profile
    {
        protected void Configure()
        {
            CreateMap<FLegalPersonTest, FLegalPerson>();
            CreateMap<FLegalPerson, FLegalPersonDto>();
            CreateMap<FLegalPerson, FLegalPersonTest>();
            CreateMap<FatherClassTest, FatherClass>();
            CreateMap<FatherClass, FatherClassDto>();
            CreateMap<FAdministrativeCoercionTest, FAdministrativeCoercion>();
            CreateMap<FAdministrativeCoercion, FAdministrativeCoercionDto>();
        }
    }
}
