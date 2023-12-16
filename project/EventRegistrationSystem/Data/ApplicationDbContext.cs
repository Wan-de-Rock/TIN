namespace EventRegistrationSystem.Data;

using Microsoft.EntityFrameworkCore;
using EventRegistrationSystem.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { Database.EnsureCreated(); }

    public DbSet<Artist>? Artist { get; set; }
    public DbSet<Event>? Event { get; set; }
    public DbSet<Performance>? Performance { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Artist>().HasData(
            new Artist { Id = 1, Name = "Arch Enemy", NumberOfMembers = 5, EmailAddress = "arch@enemy.com" },
            new Artist { Id = 2, Name = "System Of A Down", NumberOfMembers = 4, EmailAddress = "soad@rock.com" },
            new Artist { Id = 3, Name = "Metallica", NumberOfMembers = 4, EmailAddress = "metallica@mail.com" },
            new Artist { Id = 4, Name = "Lumen", NumberOfMembers = 5, EmailAddress = "lumen@mail.ru" },
            new Artist { Id = 5, Name = "Slot", NumberOfMembers = 5, EmailAddress = "slot@mail.ru" },
            new Artist { Id = 6, Name = "KAZKA", NumberOfMembers = 3, EmailAddress = "kazka@mail.ua" }
        );

        modelBuilder.Entity<Event>().HasData(
            new Event { Id = 1, Name = "Coachella", Date = new DateTime(day: 8, month: 6, year: 2023), Description = "Some description" },
            new Event { Id = 2, Name = "Lollapalooza", Date = new DateTime(day: 3, month: 8, year: 2023), Description = "Lollapalooza is a 4-Day music festival happening August 3-6, 2023 at historic Grant Park in Chicago, Illinois, USA." },
            new Event { Id = 3, Name = "Rock in Rio", Date = new DateTime(day: 12, month: 7, year: 2023), Description = "Rock in Rio is a recurring music festival originating in Rio de Janeiro, Brazil. It later branched into other locations such as Lisbon, Madrid and Las Vegas." },
            new Event { Id = 4, Name = "Tomorrowland", Date = new DateTime(day: 15, month: 7, year: 2023), Description = "Tomorrowland is a large-scale annual electronic dance music festival held at De Schorre provincial recreational park in Boom, Antwerp Province, Belgium." }
        );

        modelBuilder.Entity<Performance>().HasData(
            new Performance { Id = 1, ArtistId = 1, EventId = 3, QueuePosition = 1, TimeOfStart = new TimeSpan(hours: 15, minutes: 0, seconds: 0) },
            new Performance { Id = 2, ArtistId = 2, EventId = 3, QueuePosition = 2, TimeOfStart = new TimeSpan(hours: 17, minutes: 0, seconds: 0) },
            new Performance { Id = 3, ArtistId = 6, EventId = 2, QueuePosition = 1, TimeOfStart = new TimeSpan(hours: 19, minutes: 30, seconds: 0) },
            new Performance { Id = 4, ArtistId = 5, EventId = 4, QueuePosition = 2, TimeOfStart = new TimeSpan(hours: 19, minutes: 40, seconds: 0) },
            new Performance { Id = 5, ArtistId = 1, EventId = 1, QueuePosition = 1, TimeOfStart = new TimeSpan(hours: 16, minutes: 0, seconds: 0) },
            new Performance { Id = 6, ArtistId = 3, EventId = 1, QueuePosition = 2, TimeOfStart = new TimeSpan(hours: 17, minutes: 0, seconds: 0) },
            new Performance { Id = 7, ArtistId = 2, EventId = 1, QueuePosition = 3, TimeOfStart = new TimeSpan(hours: 20, minutes: 0, seconds: 0) },
            new Performance { Id = 8, ArtistId = 4, EventId = 1, QueuePosition = 4, TimeOfStart = new TimeSpan(hours: 20, minutes: 45, seconds: 0) },
            new Performance { Id = 9, ArtistId = 3, EventId = 3, QueuePosition = 3, TimeOfStart = new TimeSpan(hours: 21, minutes: 38, seconds: 0) }
        );
    }
}
