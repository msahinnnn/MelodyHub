using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Album.GetAll
{
    public class GetAllAlbumsQueryHandler : IRequestHandler<GetAllAlbumsQueryRequest, GetAllAlbumsQueryResponse>
    {
        private readonly IAlbumService _albumService;

        public GetAllAlbumsQueryHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<GetAllAlbumsQueryResponse> Handle(GetAllAlbumsQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _albumService.GetAllAlbums(request.Skip, request.Take);

            return new GetAllAlbumsQueryResponse
            {
                Albums = response
            };
        }
    }
   
}