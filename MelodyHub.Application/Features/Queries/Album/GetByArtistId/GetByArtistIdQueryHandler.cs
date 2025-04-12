using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Album.GetByArtistId
{
    public class GetByArtistIdQueryHandler : IRequestHandler<GetByArtistIdQueryRequest, GetByArtistIdQueryResponse>
    {
        private readonly IAlbumService _albumService;

        public GetByArtistIdQueryHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<GetByArtistIdQueryResponse> Handle(GetByArtistIdQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _albumService.GetAlbumsByArtistId(request.Id, request.Skip, request.Take);
            return new()
            {
                Albums = response
            };
        }
    }

}