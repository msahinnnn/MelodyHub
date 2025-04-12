using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Album.GetByUrl
{
    public class GetByUrlQueryHandler : IRequestHandler<GetByUrlQueryRequest, GetByUrlQueryResponse>
    {
        private readonly IAlbumService _albumService;

        public GetByUrlQueryHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<GetByUrlQueryResponse> Handle(GetByUrlQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _albumService.GetAlbumByUrl(request.Url);

            return new()
            {
                Album = response
            };
        }
    }
  
}