using MediatR;
using MelodyHub.Application.Features.Commands.Artist.CreateArtist;
using MelodyHub.Application.Features.Commands.Artist.DeleteArtist;
using MelodyHub.Application.Features.Commands.Artist.UpdateArtist;
using MelodyHub.Application.Features.Queries.Artist.GetAll;
using MelodyHub.Application.Features.Queries.Artist.GetById;
using MelodyHub.Application.Features.Queries.Artist.GetByUrl;
using Microsoft.AspNetCore.Mvc;

namespace MelodyHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ArtistController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll([FromQuery] GetAllQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByUrl([FromQuery] GetByUrlQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateArtist([FromBody] CreateArtistCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArtist([FromBody] UpdateArtistCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteArtist([FromBody] DeleteArtistCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
