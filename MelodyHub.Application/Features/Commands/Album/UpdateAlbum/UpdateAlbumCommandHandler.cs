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
            var response = await _albumService.UpdateAlbum(new()
            {
                Name = request.Name,
                GenreId = request.GenreId,
            });

            return new UpdateAlbumCommandResponse
            {
                Album = response
            };
        }
    }

}