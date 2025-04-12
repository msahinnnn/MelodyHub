using Amazon.Runtime.Internal;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Application.Features.Commands.Song.UpdateSong
{
    public class UpdateSongCommandRequest : IRequest<UpdateSongCommandResponse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Lyrics { get; set; }
        public IFormFile File { get; set; }
    }
}