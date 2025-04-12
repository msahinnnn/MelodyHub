using MediatR;
using MelodyHub.Application.Features.Commands.Genre.CreateGenre;
using MelodyHub.Application.Features.Commands.Genre.DeleteGenre;
using MelodyHub.Application.Features.Commands.Genre.UpdateGenre;
using MelodyHub.Application.Features.Queries.Genre.GetAll;
using MelodyHub.Application.Features.Queries.Genre.GetById;
using MelodyHub.Application.Features.Queries.Genre.GetByName;
using MelodyHub.Application.Features.Queries.Genre.GetByUrl;
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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByName([FromQuery] GetByNameQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
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
