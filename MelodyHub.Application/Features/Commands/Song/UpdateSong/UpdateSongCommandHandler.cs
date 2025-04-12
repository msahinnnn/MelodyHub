using MediatR;
using MelodyHub.Application.Abstractions.Services;
using MelodyHub.Application.Abstractions.Storage;
using MelodyHub.Application.Features.Commands.Song.CreateSong;
using MelodyHub.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.UpdateSong
{
    public class UpdateSongCommandHandler : IRequestHandler<UpdateSongCommandRequest, UpdateSongCommandResponse>
    {
        private readonly ISongService _songService;
        private readonly IAudioStorageService _audioStorageService;
        public UpdateSongCommandHandler(ISongService songService, IAudioStorageService audioStorageService)
        {
            _songService = songService;
            _audioStorageService = audioStorageService;
        }
        public async Task<UpdateSongCommandResponse> Handle(UpdateSongCommandRequest request, CancellationToken cancellationToken)
        {
            var entityToUpdate = await _songService.GetSongById(request.Id);

            if (entityToUpdate == null)
                throw new ArgumentException("Song not found.");

            if (request.File == null || request.File.Length == 0)
                throw new ArgumentException("No file uploaded or file is empty.");

            entityToUpdate.SongFileUrl = UrlHelper.GetSongSoundUrl(entityToUpdate.Id, entityToUpdate.AlbumId, "mymelody-hub");
            entityToUpdate.Url = UrlHelper.GetSongUrl(entityToUpdate.Id);
            entityToUpdate.Name = request.Name;
            entityToUpdate.Lyrics = request.Lyrics; 
            entityToUpdate.Duration = AudioDurationHelper.EstimateMp4Duration(request.File);

            var entityUpdateResponse = await _songService.UpdateSong(entityToUpdate);

            await _audioStorageService.UpdateSongAsync(entityUpdateResponse.Id.ToString(), entityUpdateResponse.AlbumId, request.File.OpenReadStream());

            return new UpdateSongCommandResponse
            {
                Song = entityUpdateResponse
            };
        }
    }
}