using DDD.Prac.Domain.Entities;
using MediatR;

namespace DDD.Prac.MediatR.Quries.Capital_Queries
{
    public class GetCapitalByCountryNameQuery : IRequest<Capital>
    { 
        public string country_name { get; set; } 
    }
}
