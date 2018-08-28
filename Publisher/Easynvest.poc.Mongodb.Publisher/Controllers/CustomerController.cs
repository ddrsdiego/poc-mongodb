using Easynvest.poc.Mongodb.Common;
using Easynvest.poc.Mongodb.Publisher.Application.Commands;
using Easynvest.poc.Mongodb.Publisher.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace Easynvest.poc.Mongodb.Publisher.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(Response<CreateCustomerResponse>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(Response<CreateCustomerResponse>), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(void), (int)HttpStatusCode.InternalServerError)]
        public async Task<ActionResult<Response<CreateCustomerResponse>>> Create([FromBody] CreateCustomerCommand command)
        {
            var response = await _mediator.Send(command).ConfigureAwait(false);
            if (response.IsFailure)
                return BadRequest(response);

            return Ok(response);
        }
    }
}