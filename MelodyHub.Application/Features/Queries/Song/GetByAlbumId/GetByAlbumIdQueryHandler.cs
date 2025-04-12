using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Song.GetByAlbumId
{
    public class GetByAlbumIdQueryHandler : IRequestHandler<GetByAlbumIdQueryRequest, GetByAlbumIdQueryResponse>
    {
        private readonly ISongService _songService;

        public GetByAlbumIdQueryHandler(ISongService songService)
        {
            _songService = songService;
        }

        public async Task<GetByAlbumIdQueryResponse> Handle(GetByAlbumIdQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _songService.GetSongsByAlbumId(request.AlbumId, request.Skip, request.Take);

            return new GetByAlbumIdQueryResponse
            {
                Songs = response
            };
        }
    }
}