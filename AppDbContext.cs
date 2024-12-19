using Microsoft.EntityFrameworkCore;
using laboratory_12.Models;
using System.Collections.Generic;
namespace laboratory_12.Data
{


    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pilots> Pilotss { get; set; }
        public DbSet<Airplanes> Airplaness { get; set; }
        public DbSet<Timetable> Timetabless { get; set; }
    }
}
