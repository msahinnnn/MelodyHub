using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Song.GetByName
{
    public class GetByNameQueryHandler : IRequestHandler<GetByNameQueryRequest, GetByNameQueryResponse>
    {
        private readonly ISongService _songService;

        public GetByNameQueryHandler(ISongService songService)
        {
            _songService = songService;
        }

        public async Task<GetByNameQueryResponse> Handle(GetByNameQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _songService.GetSongByName(request.Name);

            return new()
            {
                Songs = response
            };
        }
    }
}