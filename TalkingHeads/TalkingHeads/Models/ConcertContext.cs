using System;
using Microsoft.EntityFrameworkCore;

namespace TalkingHeads.Models
{
    public class ConcertContext : DbContext
    {
        public ConcertContext(DbContextOptions<ConcertContext> options)
            : base(options)
        { }

        public DbSet<Concert> Concerts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concert>().HasData(
                new Concert
                {
                    ConcertId = 1,
                    Date = new DateTime(1982, 8,15),
                    Venue = "Pine Knob Music Theater",
                    Location = "Clarkston, Michigan, USA"
                },
                new Concert
                {
                    ConcertId = 2,
                    Date = new DateTime(1982, 8, 16),
                    Venue = "Poplar Creek",
                    Location = "Hoffman Estates, Illinois, USA"
                },
                new Concert
                {
                    ConcertId = 3,
                    Date = new DateTime(1982, 8, 17),
                    Venue = "Civic Center",
                    Location = "Des Moines, Iowa, USA"
                },
                new Concert
                {
                    ConcertId = 4,
                    Date = new DateTime(1982, 8, 18),
                    Venue = "Northrop Auditorium",
                    Location = "Minneapolis, Minnesota, USA"
                },
                new Concert
                {
                    ConcertId = 5,
                    Date = new DateTime(1982, 8, 20),
                    Venue = "Paramount Theater",
                    Location = "Staten Island, New York, USA"
                },
                new Concert
                {
                    ConcertId = 6,
                    Date = new DateTime(1982, 8, 21),
                    Venue = "Tennis Stadium",
                    Location = "Forrest Hills, New York, USA"
                },
                new Concert
                {
                    ConcertId = 7,
                    Date = new DateTime(1982, 8, 23),
                    Venue = "Performing Arts Center",
                    Location = "Saratoga Springs, New York, USA"
                },
                new Concert
                {
                    ConcertId = 8,
                    Date = new DateTime(1982, 8, 24),
                    Venue = "Merriweather Post Pavilion",
                    Location = "Columbia, Maryland, USA"
                },
                new Concert
                {
                    ConcertId = 9,
                    Date = new DateTime(1982, 8, 25),
                    Venue = "Agora Ballroom",
                    Location = "West Hartford, Connecticut, USA"
                },
                new Concert
                {
                    ConcertId = 10,
                    Date = new DateTime(1982, 8, 27),
                    Venue = "Orpheum Theater",
                    Location = "Boston, Massachusetts, USA"
                }
            );
        }
    }
}