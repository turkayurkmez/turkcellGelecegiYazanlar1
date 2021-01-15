using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEFCore.Models
{
   public class MovieArtist
    {
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

    }
}
