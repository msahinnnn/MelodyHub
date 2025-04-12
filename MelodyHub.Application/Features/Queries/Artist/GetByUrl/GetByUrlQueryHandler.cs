using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Artist.GetByUrl
{
    public class GetByUrlQueryHandler : IRequestHandler<GetByUrlQueryRequest, GetByUrlQueryResponse>
    {
        private readonly IArtistService _artistService;

        public GetByUrlQueryHandler(IArtistService artistService)
        {
            _artistService = artistService;
        }

        public async Task<GetByUrlQueryResponse> Handle(GetByUrlQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _artistService.GetArtistByUrl(request.Url);

            return new()
            {
                Artist = response
            };
        }
    }
}