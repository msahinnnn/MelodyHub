using MelodyHub.Application.Abstractions.Storage;
using MelodyHub.Application.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MelodyHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        public readonly IImageStorageService _imageStorageService;
        public readonly IAudioStorageService _audioStorageService;

        public TestController(IImageStorageService imageStorageService, IAudioStorageService audioStorageService)
        {
            _imageStorageService = imageStorageService;
            _audioStorageService = audioStorageService;
        }

        // DOGRU CALISIYOR
        // Song Get
        //[HttpGet("get/song")]
        //public async Task<IActionResult> GetSong(string songId)
        //{
        //    var stream = await _audioStorageService.GetSongAsync(songId);
        //    return File(stream, "audio/mp4", $"{songId}.mp4");
        //}

        // DOGRU CALISIYOR
        // [HttpPost("upload/song")]
        // public async Task<IActionResult> UploadSong(IFormFile file)
        // {
        //     using var stream = file.OpenReadStream();
        //     await _audioStorageService.UploadSongAsync("1", stream);
        //     return Ok($"Song uploaded: songs/{1}.mp4");
        // }



        // DOGRU CALISIYOR
        //Generic Photo Upload
        //[HttpPost("upload/photo")]
        // public async Task<IActionResult> UploadPhoto(IFormFile file)
        // {
        //     if (file == null || file.Length == 0)
        //     {
        //         return BadRequest("No file uploaded or file is empty.");
        //     }

        //     using var stream = file.OpenReadStream();
        //     await _imageStorageService.UploadPhotoAsync("1", EntityStorageType.Users, PhotoType.Profile, stream);

        //     return Ok();
        // }



        // Generic Photo Delete
        //[HttpDelete("delete/photo")]
        // public async Task<IActionResult> DeletePhoto(string entityId, EntityStorageType entityType, PhotoType photoType)
        // {
        //     await _imageStorageService.DeletePhotoAsync(entityId, entityType, photoType);
        //     return Ok();
        // }


        // DOGRU CALISIYOR
        // Generic Photo Get
        //[HttpGet("get/photo")]
        //public async Task<IActionResult> GetPhoto()
        //{
        //    var stream = await _imageStorageService.GetPhotoAsync("1", EntityStorageType.Users, PhotoType.Profile);
        //    string fileName = EntityStorageType.Users switch
        //    {
        //        EntityStorageType.Playlists => $"{1}.jpg",
        //        EntityStorageType.Albums => $"{1}.jpg",
        //        _ => PhotoType.Profile == PhotoType.Profile ? "profile.jpg" : "banner.jpg"
        //    };
        //    return File(stream, "image/jpeg", fileName);
        //}


    }
}
