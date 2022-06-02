using System.Threading;
using System.Threading.Tasks;
using GreenThumb.Application.Features.GreenHouse;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GreenThumb.Features.GreenHouse
{
    [ApiController]
    [Route("/greenhouse")]
    public class GreenHouseController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GreenHouseController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<Application.Features.GreenHouse.GreenHouse> Index(int id, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetGreenHouse.Query(id), cancellationToken);

        }
    }
}