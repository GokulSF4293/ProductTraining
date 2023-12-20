using Microsoft.EntityFrameworkCore;

namespace libraryManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {

        }

        public DbSet<Library> Libraries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Library>().HasData(
                new Library
                {
                    BookId = 1,
                    CategoryName = Department.IT,
                    UpdatedOn = new DateTime(2019, 11, 27),
                    IsDeleted = false,
                    BookName = "C++",
                    AuthorName = "Balaguruswamy",
                    PublishedYear = 2001,
                    Price = 500
                },
                new Library
                {
                    BookId = 2,
                    CategoryName = Department.Electronics,
                    UpdatedOn = new DateTime(2019, 11, 28),
                    IsDeleted = false,
                    BookName = "Microcontrollers",
                    AuthorName = "Mazidi",
                    PublishedYear = 2002,
                    Price = 550
                },
                new Library
                {
                    BookId = 3,
                    CategoryName = Department.Mechanical,
                    UpdatedOn = new DateTime(2019, 11, 29),
                    IsDeleted = false,
                    BookName = "Robotics",
                    AuthorName = "Sebastian",
                    PublishedYear = 2003,
                    Price = 600
                },
                new Library
                {

                    BookId = 4,
                    CategoryName = Department.Civil,
                    UpdatedOn = new DateTime(2019, 11, 21),
                    IsDeleted = false,
                    BookName = "Structural Engineering",
                    AuthorName = "Jacques Heyman",
                    PublishedYear = 2004,
                    Price = 800
                },
                new Library
                {
                    CategoryName = Department.Electricals,
                    BookId = 5,
                    UpdatedOn = new DateTime(2019, 11, 01),
                    IsDeleted = false,
                    BookName = "DC Motors",
                    AuthorName = "Michael Faraday",
                    PublishedYear = 2004,
                    Price = 400
                },
                new Library
                {
                    CategoryName = Department.Economics,
                    BookId = 6,
                    UpdatedOn = new DateTime(2019, 11, 02),
                    IsDeleted = true,
                    BookName = "Economics",
                    AuthorName = "Nassim Nicholas",
                    PublishedYear = 2005,
                    Price = 300
                },
                new Library
                {
                    CategoryName = Department.IT,
                    BookId = 7,
                    UpdatedOn = new DateTime(2019, 11, 03),
                    IsDeleted = false,
                    BookName = "Data Structure",
                    AuthorName = "-",
                    PublishedYear = 0,
                    Price = 430
                },
                new Library
                {
                    CategoryName = Department.IT,
                    BookId = 8,
                    UpdatedOn = new DateTime(2019, 11, 04),
                    IsDeleted = true,
                    BookName = "Operating Systems",
                    AuthorName = "Abraham Silberschatz",
                    PublishedYear = 2007,
                    Price = 0
                },
                new Library
                {
                    CategoryName = Department.Electronics,
                    BookId = 9,
                    UpdatedOn = new DateTime(2019, 11, 02),
                    IsDeleted = false,
                    BookName = "Digital Electronics",
                    AuthorName = "Wikliam Gothmann",
                    PublishedYear = 0,
                    Price = 0
                }
                ); ;
        }
    }
}
