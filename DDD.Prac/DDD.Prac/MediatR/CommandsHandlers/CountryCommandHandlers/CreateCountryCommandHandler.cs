using DDD.Prac.Domain.Entities;
using DDD.Prac.Domain.IRepository;
using DDD.Prac.MediatR.Commands.CountryCommands;
using DDD.Prac.Model.Response;
using MediatR;

namespace DDD.Prac.MediatR.CommandsHandlers.CountryCommandHandlers
{
    public class CreateCountryCommandHandler : IRequestHandler<CreateCountryCommand, ApiResponse>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ILogger<CreateCountryCommandHandler> _logger;

        public CreateCountryCommandHandler(ICountryRepository countryRepository,
                                           ILogger<CreateCountryCommandHandler> logger)
        {
            _countryRepository = countryRepository;
            _logger = logger;
        }
        public async Task<ApiResponse> Handle(CreateCountryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var country = new Domain.Entities.Country().SetCountry("India", "+91");
                await _countryRepository.AddCountry(country);
                return ApiResponse.ResponseMessages(country.Id, true, "Country added sucessfully");
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, $"error occured {{0}}", nameof(CreateCountryCommandHandler));
                throw; 
            }
        }

        }
    }

