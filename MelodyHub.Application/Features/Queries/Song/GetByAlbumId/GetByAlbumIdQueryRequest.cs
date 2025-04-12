using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Song.GetByAlbumId
{
    public class GetByAlbumIdQueryRequest : IRequest<GetByAlbumIdQueryResponse>
    {
        public int AlbumId { get; set; }
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = 10;
    }
}