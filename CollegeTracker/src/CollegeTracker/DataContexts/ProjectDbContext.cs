using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeTracker.Models;
using Microsoft.EntityFrameworkCore;
using CollegeTracker.Models.CalendarModels;

namespace CollegeTracker.DataContexts
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CollegeTracker;Trusted_Connection=True;");
        }

        public DbSet<Deadline> Deadlines { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<EntranceTest> EntranceTests { get; set; }

    }
}