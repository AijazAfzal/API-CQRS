using DDD.Prac.Domain.Entities;
using DDD.Prac.Domain.IRepository;
using DDD.Prac.MediatR.Quries.Capital_Queries;
using MediatR;

namespace DDD.Prac.MediatR.QueryHandlers.Capital_QueryHandlers
{
    public class GetAllCapitalQueryHandler : IRequestHandler<GetAllCapitalQuery, IList<Capital>>
    {
        private readonly ICapitalRepository _capitalRepository;
        private readonly ILogger<GetAllCapitalQueryHandler> _logger;
        public GetAllCapitalQueryHandler(ICapitalRepository capitalRepository,
            ILogger<GetAllCapitalQueryHandler> logger)
        {
            _capitalRepository = capitalRepository;
            _logger = logger; 
        }
        public async Task<IList<Capital>> Handle(GetAllCapitalQuery request, CancellationToken cancellationToken)
        {
            try
            {
                return await _capitalRepository.GetAllCapitals();
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, $"error occured {{0}}", nameof(GetAllCapitalQueryHandler)); 
                throw;
            }
        }
    }
}
