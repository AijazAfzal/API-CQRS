using DDD.Prac.Domain.Entities;
using MediatR;

namespace DDD.Prac.MediatR.Quries.Capital_Queries
{
    public class GetAllCapitalQuery : IRequest<IList<Capital>>
    {

    }
}
