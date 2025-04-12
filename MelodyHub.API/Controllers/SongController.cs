using MediatR;
using MelodyHub.Application.Features.Commands.Song.CreateSong;
using MelodyHub.Application.Features.Commands.Song.DeleteSong;
using MelodyHub.Application.Features.Commands.Song.UpdateSong;
using MelodyHub.Application.Features.Queries.Song.GetAll;
using MelodyHub.Application.Features.Queries.Song.GetByAlbumId;
using MelodyHub.Application.Features.Queries.Song.GetById;
using MelodyHub.Application.Features.Queries.Song.GetByName;
using MelodyHub.Application.Features.Queries.Song.GetByUrl;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MelodyHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SongController(IMediator mediator)
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
        public async Task<IActionResult> GetByAlbumId([FromQuery] GetByAlbumIdQueryRequest request)
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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByUrl([FromQuery] GetByUrlQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }


        [HttpPost]
        public async Task<IActionResult> CreateSong([FromForm] CreateSongCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSong([FromForm] UpdateSongCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteSong([FromForm] DeleteSongCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
