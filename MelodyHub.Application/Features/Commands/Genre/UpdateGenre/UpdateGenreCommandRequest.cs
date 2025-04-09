using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Genre.UpdateGenre
{
    public class UpdateGenreCommandRequest : IRequest<UpdateGenreCommandResponse>
    {
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}