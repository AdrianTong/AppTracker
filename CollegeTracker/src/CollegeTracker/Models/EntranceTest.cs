using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeTracker.Models.CalendarModels;

namespace CollegeTracker.Models
{
    public class EntranceTest
    {
        public string Name;
        public List<Deadline> TestTimes;
        public Dictionary<College, int> AverageCollegeScores;
    }
}
