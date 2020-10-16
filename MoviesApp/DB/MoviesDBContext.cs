using Microsoft.EntityFrameworkCore;
using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.DB
{
    public class MoviesDBContext : DbContext
    {
        public MoviesDBContext(DbContextOptions<MoviesDBContext>opt):base(opt)
        {

        }
    
        public DbSet<Movie> Movie { get; set; }
    }
}
