using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Album.UpdateAlbum
{
    public class UpdateAlbumCommandRequest : IRequest<UpdateAlbumCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
    }
}