using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeTracker.Models.CalendarModels
{
    public class Activity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
    }

    public class CollegeActivity : Activity
    {
        public College College { get; set; }
        
    }

    public class Deadline : CollegeActivity
    {
        public int Priority { get; set; }
    }

enum ActivityPriorities
    {
        Urgent, High, Medium, Low, Optional
    }
}
