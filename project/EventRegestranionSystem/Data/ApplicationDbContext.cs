using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventRegestranionSystem.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EventRegestranionSystem.Data
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


        public DbSet<Artist> Artist { get; set; } = default!;


        public DbSet<EventRegestranionSystem.Models.Event> Event { get; set; }


        public DbSet<EventRegestranionSystem.Models.Performance> Performance { get; set; }
    }

    public class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(
                d => d.ToDateTime(TimeOnly.MinValue),
                d => DateOnly.FromDateTime(d))
        { }
    }
}
