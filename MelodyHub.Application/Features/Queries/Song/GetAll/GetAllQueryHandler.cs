using MediatR;
using MelodyHub.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Song.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQueryRequest, GetAllQueryResponse>
    {
        private readonly ISongService _songService;

        public GetAllQueryHandler(ISongService songService)
        {
            _songService = songService;
        }

        public async Task<GetAllQueryResponse> Handle(GetAllQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _songService.GetAllSongs(request.Skip, request.Take);

            return new()
            {
                Songs = response
            };
        }
    }
}