using AutoMapper;
using DDD.Prac.Domain.Entities;
using DDD.Prac.MediatR.Commands.CapitalCommands;
using DDD.Prac.MediatR.Commands.CountryCommands;
using DDD.Prac.Model.Request;
using DDD.Prac.Model.Response;

namespace DDD.Prac.Mapper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateCapitalCommand, CreateCapitalRequest>().ReverseMap();
            CreateMap<CreateCountryCommand, CreateCountryRequest>().ReverseMap();
            CreateMap<Domain.Entities.Country, Model.Response.Country>().ReverseMap();
            CreateMap<Domain.Entities.Capital, Model.Response.Capital>().ReverseMap(); 
        }
    }
}
