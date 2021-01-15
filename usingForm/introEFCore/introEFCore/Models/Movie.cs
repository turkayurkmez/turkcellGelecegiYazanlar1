using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEFCore.Models
{
   public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public double? Rating { get; set; }

        public string Summary { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Country { get; set; }

        public int DirectorId { get; set; }
        public Director Director { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public IList<MovieArtist> Artists { get; set; }

    }
}
