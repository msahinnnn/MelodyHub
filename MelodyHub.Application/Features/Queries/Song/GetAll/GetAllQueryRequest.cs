using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Song.GetAll
{
    public class GetAllQueryRequest : IRequest<GetAllQueryResponse>
    {
        public int Skip { get; set; } = 0;
        public int Take { get; set; } = 10;
    }
}