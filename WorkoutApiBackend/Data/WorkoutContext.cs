using System.Collections.Generic;
using ConfigurationLibrary.Classes;
using Microsoft.EntityFrameworkCore;
using WorkoutApiBackend.Models;

namespace WorkoutApiBackend.Data
{
    public class WorkoutContext : DbContext
    {
        public DbSet<Workout> Workout { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet(ConfigurationHelper.ConnectionString());
        }
    }
}
