using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Abstractions.Storage;
using MelodyHub.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.CreateSong
{
    public class CreateSongCommandHandler : IRequestHandler<CreateSongCommandRequest, CreateSongCommandResponse>
    {
        private readonly ISongService _songService;
        private readonly IAudioStorageService _audioStorageService;
        public CreateSongCommandHandler(ISongService songService, IAudioStorageService audioStorageService)
        {
            _songService = songService;
            _audioStorageService = audioStorageService;
        }

        public async Task<CreateSongCommandResponse> Handle(CreateSongCommandRequest request, CancellationToken cancellationToken)
        {
            var createdEntity = await _songService.CreateSong(new()
            {
                Name = request.Name,
                Lyrics = request.Lyrics,
                AlbumId = request.AlbumId,
                Duration = AudioDurationHelper.EstimateMp4Duration(request.File)
            });

            createdEntity.SongFileUrl = UrlHelper.GetSongSoundUrl(createdEntity.Id, createdEntity.AlbumId, "mymelody-hub");
            createdEntity.Url = UrlHelper.GetSongUrl(createdEntity.Id);

            var updatedEntity = await _songService.UpdateSong(createdEntity);

            await _audioStorageService.UploadSongAsync(updatedEntity.Id.ToString(), updatedEntity.AlbumId, request.File.OpenReadStream());

            return new CreateSongCommandResponse
            {
                Song = updatedEntity
            };
        }
    }
}