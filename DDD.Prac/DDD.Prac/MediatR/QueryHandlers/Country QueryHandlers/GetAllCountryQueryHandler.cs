using DDD.Prac.Domain.Entities;
using DDD.Prac.Domain.IRepository;
using DDD.Prac.MediatR.Quries.CountryQueries;
using MediatR;

namespace DDD.Prac.MediatR.QueryHandlers.Country_QueryHandlers
{
    public class GetAllCountryQueryHandler : IRequestHandler<GetAllCountryQuery, IList<Country>>
    {
        private readonly ICountryRepository _countryRepository;
        private readonly ILogger<GetAllCountryQueryHandler> _logger; 
        public GetAllCountryQueryHandler(ICountryRepository countryRepository,
            ILogger<GetAllCountryQueryHandler> logger )
        {
                _logger= logger;
                _countryRepository= countryRepository;   
        }
        public async Task<IList<Country>> Handle(GetAllCountryQuery request, CancellationToken cancellationToken)
        {
            try 
            {
                return await _countryRepository.GetAllCountries(); 
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, $"error occured {{0}}", nameof(GetAllCountryQueryHandler));
                throw;  
            }
        }
    }
}
