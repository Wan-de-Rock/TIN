using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventRegistrationSystem.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventRegistrationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("date");
        }

        public DbSet<EventRegistrationSystem.Models.Artist> Artist { get; set; }

        public DbSet<EventRegistrationSystem.Models.Event> Event { get; set; }

        public DbSet<EventRegistrationSystem.Models.Performance> Performance { get; set; }
    }

    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        { }
    }
}
