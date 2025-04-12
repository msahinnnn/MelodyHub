using Amazon.Runtime.Internal;
using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Album.GetByName
{
    public class GetByNameQueryHandler : IRequestHandler<GetByNameQueryRequest, GetByNameQueryResponse>
    {
        private readonly IAlbumService _albumService;

        public GetByNameQueryHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<GetByNameQueryResponse> Handle(GetByNameQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _albumService.GetAlbumByName(request.Name);

            return new()
            {
                Album = response
            };
        }
    }
}