using Microsoft.EntityFrameworkCore;

namespace TripsApp.Models
{
    public class TripLogContext : DbContext
    {
      public TripLogContext(DbContextOptions<TripLogContext> options)
            : base(options) { }

      public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripId = 1,
                  Destination = "Boise",
                    StartDate = new DateTime(2023, 6, 6, 15, 0, 0, 0),
                    EndDate = new DateTime(2023, 6, 14, 11, 0, 0, 0),
                 Accommodation = "",
                    AccommodationPhone = "",
                  AccommodationEmail = "",
                   ThingToDo1 = "Visit Tammy",
                    ThingToDo2 = "",
                    ThingToDo3 = ""
                },
                new Trip
                {
                    TripId = 2,
                 Destination = "Portland",
                    StartDate = new DateTime(2024, 1, 1, 15, 0, 0, 0),
                 EndDate = new DateTime(2024, 1, 7, 11, 0, 0, 0),
                    Accommodation = "The Benson Hotel",
                  AccommodationPhone = "503-555-1234",
                    AccommodationEmail = "staff@bensonhotel.com",
                  ThingToDo1 = "Go to Voodoo Doughnuts",
                    ThingToDo2 = "Walk in the rain",
                  ThingToDo3 = "Go to Powell's"
                }
            );
        }
    }
}
