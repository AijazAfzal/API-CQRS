using DDD.Prac.Domain.Entities;
using MediatR;

namespace DDD.Prac.MediatR.Quries.CountryQueries
{
    public record GetCountryByCodeQuery : IRequest<Country>
    {
        public string Country_code { get; set; } 
    }
}
