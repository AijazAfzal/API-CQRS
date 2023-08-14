using AutoMapper;
using DDD.Prac.MediatR.Quries.Capital_Queries;
using DDD.Prac.Model.Response;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Prac.Controller.QueryControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CapitalQueryController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CapitalQueryController(IMediator mediator,
            IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper; 
        }

        [HttpGet("GetCapitalListAsync")]
        [ProducesResponseType(typeof(IList<Capital>),StatusCodes.Status200OK)] 
        public async Task<IActionResult> GetCapitalListAsync()
        {
            return Ok(_mapper.Map<IList<Capital>>(await _mediator.Send(new GetAllCapitalQuery()))); 
        }

        [HttpGet("GetCapitalByCountryNameAsync")]
        [ProducesResponseType(typeof(Capital), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCapitalByCountryNameAsync()
        {
            return Ok(_mapper.Map<Capital>(await _mediator.Send(new GetCapitalByCountryNameQuery()))); 
        }
    }
}
