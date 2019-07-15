using System;
using System.Collections.Generic;

namespace PoliceViolenceMap.Models
{
    public partial class PoliceKillingsOfBlackMen
    {
        public double IncidentId { get; set; }
        public string City { get; set; }
        public string Pd { get; set; }
        public double? BlackMenKilledByPolice11201312312017 { get; set; }
        public double? BlackMalePopulation2015Acs { get; set; }
        public double? AveragePoliceHomicideRateForBlackMenPer100000 { get; set; }
    }
}
