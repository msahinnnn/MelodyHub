using MediatR;
using MelodyHub.Application.Features.Commands.Album.CreateAlbum;
using MelodyHub.Application.Features.Commands.Album.DeleteAlbum;
using MelodyHub.Application.Features.Commands.Album.UpdateAlbum;
using MelodyHub.Application.Features.Commands.Artist.CreateArtist;
using MelodyHub.Application.Features.Commands.Artist.DeleteArtist;
using MelodyHub.Application.Features.Commands.Artist.UpdateArtist;
using Microsoft.AspNetCore.Http;
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
