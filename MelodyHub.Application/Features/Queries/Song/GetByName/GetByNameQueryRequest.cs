using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Song.GetByName
{
    public class GetByNameQueryRequest : IRequest<GetByNameQueryResponse>
    {
        public string Name { get; set; }
    }
}