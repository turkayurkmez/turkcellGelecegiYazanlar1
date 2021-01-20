using introEFCore.Data;
using introEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introEFCore.Services
{
   public class DirectorBusiness
    {
        TurkcellDbContext dbContext = new TurkcellDbContext();
        public List<Director> GetDirectors()
        {
            return dbContext.Directors.ToList();
        }
        public Director GetDirectorById(int id)
        {
            return dbContext.Directors.Find(id);
        }

        public void Add(Director director)
        {
            dbContext.Directors.Add(director);
            dbContext.SaveChanges();
        }

        public void Remove(Director director)
        {
            dbContext.Directors.Remove(director);
            dbContext.SaveChanges();
        }

        public void Edit(Director director)
        {
            dbContext.Entry(director).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();

        }
    }
}
