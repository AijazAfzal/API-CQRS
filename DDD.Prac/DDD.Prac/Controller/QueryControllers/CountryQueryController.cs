using AutoMapper;
using DDD.Prac.MediatR.Quries.CountryQueries;
using DDD.Prac.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Prac.Controller.QueryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryQueryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CountryQueryController(IMediator mediator,
            IMapper mapper)
        {
            _mapper = mapper;
            _mediator = mediator;    
        }

        [HttpGet("GetCountryListAsync")]
        [ProducesResponseType(typeof(IList<Country>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCountryListAsync()
        {

            return Ok(_mapper.Map<IList<Country>>(await _mediator.Send(new GetAllCountryQuery()))); 
        }

        [HttpGet("GetCountryByCodeAsync")]
        [ProducesResponseType(typeof(Country),StatusCodes.Status200OK)] 
        public async Task<IActionResult> GetCountryByCodeAsync()
        {
            return Ok(_mapper.Map<Country>(await _mediator.Send(new GetCountryByCodeQuery()))); 
        }
    }
}
