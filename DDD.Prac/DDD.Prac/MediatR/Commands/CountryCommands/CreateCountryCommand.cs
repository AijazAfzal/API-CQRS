using DDD.Prac.Model.Response;
using MediatR;

namespace DDD.Prac.MediatR.Commands.CountryCommands
{
    public record CreateCountryCommand : IRequest<ApiResponse>
    {

        public string Country_Name { get; set; }

        public string Country_code { get; set; } 
    }
}
