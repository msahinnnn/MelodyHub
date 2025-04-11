using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Album.UpdateAlbum
{
    public class UpdateAlbumCommandHandler : IRequestHandler<UpdateAlbumCommandRequest, UpdateAlbumCommandResponse>
    {
        private readonly IAlbumService _albumService;

        public UpdateAlbumCommandHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }
        public async Task<UpdateAlbumCommandResponse> Handle(UpdateAlbumCommandRequest request, CancellationToken cancellationToken)
        {
            var entity = await _albumService.GetAlbumById(request.Id);

            if (entity == null)
            {
                throw new Exception("Album not found");
            }

            entity.Name = string.IsNullOrEmpty(request.Name) ? entity.Name : request.Name;
            entity.GenreId = request.GenreId > 0 ? entity.GenreId : request.GenreId;


            var response = await _albumService.UpdateAlbum(entity);

            return new UpdateAlbumCommandResponse
            {
                Album = response
            };
        }
    }

}