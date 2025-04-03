using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Artist.DeleteArtist
{
    public class DeleteArtistCommandRequest : IRequest<DeleteArtistCommandResponse>
    {
    }
}