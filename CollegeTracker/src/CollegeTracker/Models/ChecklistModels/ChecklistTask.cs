using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CollegeTracker.Models.ChecklistModels
{
    public class ChecklistTask
    {
        public int ChecklistTaskID { get; set; }
        
        public string Content { get; set; }
        public ApplicationUser user { get; set; }
    }
}
