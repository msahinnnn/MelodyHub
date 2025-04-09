using MediatR;
using MelodyHub.Application.Features.Commands.Genre.CreateGenre;
using MelodyHub.Application.Features.Commands.Genre.DeleteGenre;
using MelodyHub.Application.Features.Commands.Genre.UpdateGenre;
using MelodyHub.Application.Features.Commands.Photo.CreatePhoto;
using MelodyHub.Application.Features.Commands.Photo.DeletePhoto;
using MelodyHub.Application.Features.Commands.Photo.UpdatePhoto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MelodyHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PhotoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreatePhoto([FromForm] CreatePhotoCommandRequest request)
        {       
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePhoto([FromForm] UpdatePhotoCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete]
        public async Task<IActionResult> DeletePhoto([FromForm] DeletePhotoCommandRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
