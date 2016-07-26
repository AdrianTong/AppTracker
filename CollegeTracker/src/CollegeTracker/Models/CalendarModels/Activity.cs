using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeTracker.Models.CalendarModels
{

    public class Deadline
    {
        [Key]
        public Guid DeadlineID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public int Priority { get; set; }
        public College College { get; set; }
    }

enum ActivityPriorities
    {
        Urgent, High, Medium, Low, Optional
    }
}
