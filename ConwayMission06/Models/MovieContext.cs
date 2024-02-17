using Microsoft.EntityFrameworkCore;

namespace ConwayMission06.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) 
        {

        }
        public DbSet<Movie> Movies { get; set;}
    }
}
