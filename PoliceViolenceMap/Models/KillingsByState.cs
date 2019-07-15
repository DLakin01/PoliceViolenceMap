using System;
using System.Collections.Generic;

namespace PoliceViolenceMap.Models
{
    public partial class KillingsByState
    {
        public double StateId { get; set; }
        public string State { get; set; }
        public double? Population { get; set; }
        public double? AfricanAmericanAlone { get; set; }
        public double? AfricanAmerican { get; set; }
        public double? VictimsBlack { get; set; }
        public double? Disparity { get; set; }
        public double? BlackPeopleKilled { get; set; }
        public double? HispanicPeopleKilled { get; set; }
        public double? NativeAmericanPeopleKilled { get; set; }
        public double? AsianPeopleKilled { get; set; }
        public double? PacificIslandersKilled { get; set; }
        public double? WhitePeopleKilled { get; set; }
        public double? UnknownRacePeopleKilled { get; set; }
        public double? PeopleKilled { get; set; }
        public double? RateBlackPeople { get; set; }
        public double? RateAllPeople { get; set; }
        public string F18 { get; set; }
    }
}
