using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Queries.Album.GetByUrl
{
    public class GetByUrlQueryRequest : IRequest<GetByUrlQueryResponse>
    {
        public string Url { get; set; }
    }
}