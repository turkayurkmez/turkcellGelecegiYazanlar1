using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEFCore.Models
{
   public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public IList<MovieArtist> Movies { get; set; }

    }
}
