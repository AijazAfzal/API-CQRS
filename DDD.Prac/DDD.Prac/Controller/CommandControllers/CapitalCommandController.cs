using AutoMapper;
using DDD.Prac.MediatR.Commands.CapitalCommands;
using DDD.Prac.Model.Request;
using DDD.Prac.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Prac.Controller.CommandControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapitalCommandController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CapitalCommandController(IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper; 
        }

        [HttpPost("CreateCapitalAsync")]
        [ProducesResponseType(typeof(ApiResponse),StatusCodes.Status201Created)] 
        public async Task<IActionResult> CreateCapitalAsync([FromBody]CreateCapitalRequest request )
        {
            return Created("",await _mediator.Send(_mapper.Map<CreateCapitalCommand>(request)));   
        }
    }
}
