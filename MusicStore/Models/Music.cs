using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicStore.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string YearReleased { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public bool Feature { get; set; }
        public string FeaturedArtist { get; set; }
        public string Genre { get; set; }
       

    }
}
