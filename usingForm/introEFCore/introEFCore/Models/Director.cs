using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEFCore.Models
{
    public class Director
    {
        //Bir yönetmenin .................... vardır
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Info { get; set; }

        //Navigation Property: 
        public IList<Movie> Movies { get; set; }


    }
}
