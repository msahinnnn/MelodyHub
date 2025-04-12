using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Album.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQueryRequest, GetByIdQueryResponse>
    {
        private readonly IAlbumService _albumService;

        public GetByIdQueryHandler(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public async Task<GetByIdQueryResponse> Handle(GetByIdQueryRequest request, CancellationToken cancellationToken)
        {
           var response = await _albumService.GetAlbumById(request.Id);
            
            return new()
            {
                Album = response
            };
        }
    }
}