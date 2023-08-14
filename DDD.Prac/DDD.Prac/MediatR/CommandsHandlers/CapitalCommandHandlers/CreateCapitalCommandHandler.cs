using DDD.Prac.Domain.Entities;
using DDD.Prac.Domain.IRepository;
using DDD.Prac.MediatR.Commands.CapitalCommands;
using DDD.Prac.Model.Response;
using MediatR;

namespace DDD.Prac.MediatR.CommandsHandlers.CapitalCommandHandlers
{
    public class CreateCapitalCommandHandler : IRequestHandler<CreateCapitalCommand, ApiResponse>
    {
        private readonly ICapitalRepository _capitalRepository;
        private readonly ILogger<CreateCapitalCommandHandler> _logger;
        public CreateCapitalCommandHandler(ICapitalRepository capitalRepository,
                                           ILogger<CreateCapitalCommandHandler> logger)
        {
            _capitalRepository = capitalRepository;
            _logger = logger; 
        }
        public async Task<ApiResponse> Handle(CreateCapitalCommand request, CancellationToken cancellationToken)
        {
            try 
            { 
           
              var capital = new Domain.Entities.Capital().SetCapital(request.Name,request.Country_Id);
              await _capitalRepository.AddCapital(capital);
              return ApiResponse.ResponseMessages(capital.Id,true,"Capital added sucessfully");
            }

            catch (Exception ex) 
            {
                _logger.LogError(ex, $"error occured {{0}}", nameof(CreateCapitalCommandHandler));
                throw; 
            }
        }
    }
}
