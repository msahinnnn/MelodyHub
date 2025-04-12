using MediatR;
using MelodyHub.Application.Features.Commands.Album.CreateAlbum;
using MelodyHub.Application.Features.Commands.Album.DeleteAlbum;
using MelodyHub.Application.Features.Commands.Album.UpdateAlbum;
using MelodyHub.Application.Features.Queries.Album.GetAll;
using MelodyHub.Application.Features.Queries.Album.GetByArtistId;
using MelodyHub.Application.Features.Queries.Album.GetByGenreId;
using MelodyHub.Application.Features.Queries.Album.GetById;
using MelodyHub.Application.Features.Queries.Album.GetByName;
using MelodyHub.Application.Features.Queries.Album.GetByUrl;
using Microsoft.AspNetCore.Mvc;

namespace MelodyHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AlbumController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetAllAlbums([FromQuery] GetAllAlbumsQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByArtistId([FromQuery] GetByArtistIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetByGenreId([FromQuery] GetByGenreIdQueryRequest request)
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
        public async Task<IActionResult> CreateAlbum([FromBody] CreateAlbumCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAlbum([FromBody] UpdateAlbumCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAlbum([FromBody] DeleteAlbumCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
