using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeTracker.Models.CalendarModels;

namespace CollegeTracker.Models
{
    public class College
    {
        public string Name;

        public Uri ApplicationUrl;

        public List<Deadline> Deadlines;

        // Info
        public int UniversityType;
        public int CampusLocale;
        public int Ownership;
        public int Population;
        public bool IsCoed;
        public bool IsCommonApp;

        // Testing
        public bool IsTestOptional;
        public bool IsSubjectTestRequired;
        public List<EntranceTest> EntranceTests;

        // $$
        public int CostTuition;
        public int CostBooks;
        public int CostRoomBoard;
        public int AidAverage;
    }

    public enum CampusLocale
    {
        Urban, Suburban, SmallTown, Rural
    }

    public enum UniversityTypes
    {
        University, TwoYear, Technical, Community
    }

    public enum Ownership
    {
        Public, Private
    }
    
}
