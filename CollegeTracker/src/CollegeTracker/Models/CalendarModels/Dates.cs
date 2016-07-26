using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeTracker.Models.CalendarModels
{
    public class Day
    {
    }

    public class Week
    {
        public List<Day> Days;
    }

    public class Month
    {
        public List<Week> Weeks;
    }

    public class Year
    {
        public List<Year> Years;
    }
}
