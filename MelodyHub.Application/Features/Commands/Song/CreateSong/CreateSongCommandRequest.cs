using Amazon.Runtime.Internal;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.CreateSong
{
    public class CreateSongCommandRequest : IRequest<CreateSongCommandResponse>
    {
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public int AlbumId { get; set; }
        public IFormFile File { get; set; }
    }

}