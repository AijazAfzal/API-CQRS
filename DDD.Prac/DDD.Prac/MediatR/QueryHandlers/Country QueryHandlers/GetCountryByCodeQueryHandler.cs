using DDD.Prac.Domain.Entities;
using DDD.Prac.Domain.IRepository;
using DDD.Prac.MediatR.Quries.CountryQueries;
using MediatR;

namespace DDD.Prac.MediatR.QueryHandlers.Country_QueryHandlers
{
    public class GetCountryByCodeQueryHandler : IRequestHandler<GetCountryByCodeQuery, Country>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ILogger<GetCountryByCodeQueryHandler> _logger; 
        public GetCountryByCodeQueryHandler(ICountryRepository countryRepository,
             ILogger<GetCountryByCodeQueryHandler> logger)
        {
            _countryRepository = countryRepository;
            _logger = logger; 
                
        }
        public async Task<Country> Handle(GetCountryByCodeQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _countryRepository.GetCountryByCode(request.Country_code); 
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, $"error occured {{0}}", nameof(GetCountryByCodeQueryHandler));
                throw; 
            }
        }
    }
}
