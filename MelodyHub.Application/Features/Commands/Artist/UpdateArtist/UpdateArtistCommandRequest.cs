using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Artist.UpdateArtist
{
    public class UpdateArtistCommandRequest : IRequest<UpdateArtistCommandResponse>
    {
        public int ArtistId { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
    }
}