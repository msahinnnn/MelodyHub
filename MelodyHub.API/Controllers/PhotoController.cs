using MediatR;
using MelodyHub.Application.Features.Commands.Photo.CreatePhoto;
using MelodyHub.Application.Features.Commands.Photo.DeletePhoto;
using MelodyHub.Application.Features.Commands.Photo.UpdatePhoto;
using MelodyHub.Application.Features.Queries.Photo.GetAll;
using MelodyHub.Application.Features.Queries.Photo.GetById;
using MelodyHub.Application.Features.Queries.Photo.GetByParentId;
using MelodyHub.Application.Features.Queries.Photo.GetByUrl;
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
        public async Task<IActionResult> GetByParentId([FromQuery] GetByParentIdQueryRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
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
