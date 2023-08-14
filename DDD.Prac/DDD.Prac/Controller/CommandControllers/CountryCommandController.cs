using AutoMapper;
using DDD.Prac.MediatR.Commands.CountryCommands;
using DDD.Prac.Model.Request;
using DDD.Prac.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Prac.Controller.CommandControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryCommandController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CountryCommandController(IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("CreateCountryAsync")] 
        [ProducesResponseType(typeof(ApiResponse),StatusCodes.Status201Created)] 
        public async Task<IActionResult> CreateCountryAsync([FromBody]CreateCountryRequest request)
        {
            return Created("",await _mediator.Send(_mapper.Map<CreateCountryCommand>(request)));  
        }
    }
}
