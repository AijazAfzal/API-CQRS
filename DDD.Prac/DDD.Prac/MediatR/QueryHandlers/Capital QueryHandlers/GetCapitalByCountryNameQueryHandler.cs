using DDD.Prac.Domain.Entities;
using DDD.Prac.Domain.IRepository;
using DDD.Prac.MediatR.Quries.Capital_Queries;
using MediatR;

namespace DDD.Prac.MediatR.QueryHandlers.Capital_QueryHandlers
{
    public class GetCapitalByCountryNameQueryHandler : IRequestHandler<GetCapitalByCountryNameQuery, Capital>
    {
        private readonly ICapitalRepository _capitalRepository;
        private readonly ILogger<GetCapitalByCountryNameQueryHandler> _logger;
        public GetCapitalByCountryNameQueryHandler(ICapitalRepository capitalRepository,
            ILogger<GetCapitalByCountryNameQueryHandler> logger )
        {
                _capitalRepository = capitalRepository;
                _logger = logger;    
        }
        public async Task<Capital> Handle(GetCapitalByCountryNameQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _capitalRepository.GetCapitalByCountryName(request.country_name);
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, $"error occured {{0}}", nameof(GetCapitalByCountryNameQueryHandler));
                throw; 
            }
        }
    }
}
