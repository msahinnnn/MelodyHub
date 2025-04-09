using MediatR;
using MelodyHub.Application.Features.Commands.Artist.CreateArtist;
using MelodyHub.Application.Features.Commands.Artist.DeleteArtist;
using MelodyHub.Application.Features.Commands.Artist.UpdateArtist;
using MelodyHub.Application.Features.Commands.Genre.CreateGenre;
using MelodyHub.Application.Features.Commands.Genre.DeleteGenre;
using MelodyHub.Application.Features.Commands.Genre.UpdateGenre;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MelodyHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GenreController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateArtist([FromBody] CreateGenreCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateArtist([FromBody] UpdateGenreCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteArtist([FromBody] DeleteGenreCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
