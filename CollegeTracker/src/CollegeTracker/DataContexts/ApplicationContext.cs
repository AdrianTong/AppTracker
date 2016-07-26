using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeTracker.Models;
using Microsoft.EntityFrameworkCore;
using CollegeTracker.Models.CalendarModels;
using CollegeTracker.Models.ChecklistModels;

namespace CollegeTracker.DataContexts
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        public DbSet<Deadline> Deadlines { get; set; }
        public DbSet<College> Colleges { get; set; }
        public DbSet<EntranceTest> EntranceTests { get; set; }
        public DbSet<ChecklistTask> ChecklistTasks { get; set; }



    }
}