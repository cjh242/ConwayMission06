using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConwayMission06.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) 
        {

        }
        public DbSet<Movie> Movies { get; set;}
        public DbSet<Category> Categories { get; set;}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { CategoryId = 1, CategoryName = "Action" },
        //        new Category { CategoryId = 2, CategoryName = "Adventure" },
        //        new Category { CategoryId = 3, CategoryName = "Comedy" },
        //        new Category { CategoryId = 4, CategoryName = "Drama" },
        //        new Category { CategoryId = 5, CategoryName = "Romance" },
        //        new Category { CategoryId = 6, CategoryName = "Thriller" },
        //        new Category { CategoryId = 7, CategoryName = "Horror" },
        //        new Category { CategoryId = 8, CategoryName = "Sci - Fi" },
        //        new Category { CategoryId = 9, CategoryName = "Fantasy" },
        //        new Category { CategoryId = 10, CategoryName = "Mystery" }
        //        );
        //}
    }
}
