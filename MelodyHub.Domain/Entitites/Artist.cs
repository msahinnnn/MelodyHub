using MelodyHub.Domain.Entitites.Cammon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelodyHub.Domain.Entitites
{
    public class Artist : BaseEntity
    {
        public string Name { get; set; }
        public string Url { get; set; } = "";
        public string About { get; set; }
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
        public ICollection<Album> Albums { get; set; } = new List<Album>();
    }
}
