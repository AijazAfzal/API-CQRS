using DDD.Prac.Domain.Entities;
using MediatR;

namespace DDD.Prac.MediatR.Quries.CountryQueries
{
    public record GetAllCountryQuery : IRequest<IList<Country>>
    {

    }
}
