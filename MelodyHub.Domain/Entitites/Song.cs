using MelodyHub.Domain.Entitites.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Domain.Entitites
{
    public class Song : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; } // to share
        public string SongFileUrl { get; set; } //to listen
        public string Lyrics { get; set; }
        public string Duration { get; set; }
        public int AlbumId { get; set; }
        public Album Album { get; set; }
    }
}
