using DDD.Prac.Model.Response;
using MediatR;

namespace DDD.Prac.MediatR.Commands.CapitalCommands
{
    public class CreateCapitalCommand : IRequest<ApiResponse>
    {
        public string Name { get; set; }

        public  int Country_Id { get; set; } 
    }
}
