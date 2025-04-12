using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Artist.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQueryRequest, GetAllQueryResponse>
    {
       private readonly IArtistService _artistService;
        public GetAllQueryHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }
        public async Task<GetAllQueryResponse> Handle(GetAllQueryRequest request, CancellationToken cancellationToken)
        {
            var artists = await _artistService.GetAllArtists(request.Skip, request.Take);
            return new()
            {
                Artists = artists
            };
        }
    }
 
}