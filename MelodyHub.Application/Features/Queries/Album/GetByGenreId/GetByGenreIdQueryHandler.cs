using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Album.GetByGenreId
{
    public class GetByGenreIdQueryHandler : IRequestHandler<GetByGenreIdQueryRequest, GetByGenreIdQueryResponse>
    {
        private readonly IAlbumService _albumService;

        public GetByGenreIdQueryHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<GetByGenreIdQueryResponse> Handle(GetByGenreIdQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _albumService.GetAlbumsByGenreId(request.Id, request.Skip, request.Take);

            return new()
            {
                Albums = response
            };
        }
    }

}