using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Song.GetByUrl
{
    public class GetByUrlQueryHandler : IRequestHandler<GetByUrlQueryRequest, GetByUrlQueryResponse>
    {
        private readonly ISongService _songService;

        public GetByUrlQueryHandler(ISongService songService)
        {
            _songService = songService;
        }

        public async Task<GetByUrlQueryResponse> Handle(GetByUrlQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _songService.GetSongByUrl(request.Url);

            return new()
            {
                Song = response
            };
        }
    }
}