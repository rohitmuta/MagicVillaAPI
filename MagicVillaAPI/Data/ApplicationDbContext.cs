using MagicVillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVillaAPI.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
            
        }
        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "A Royal Villa for the Royal People",
                    ImageUrl = "",
                    Occupancy = 5,
                    Rate = 250,
                    Sqft = 550,
                    Amenity = "",
                    CreatedDate = DateTime.Now
                },
                 new Villa()
                 {
                     Id = 2,
                     Name = "Mediocre Villa",
                     Details = "A Royal Villa for the Mediocre People",
                     ImageUrl = "",
                     Occupancy = 5,
                     Rate = 200,
                     Sqft = 450,
                     Amenity = "",
                     CreatedDate = DateTime.Now
                 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
