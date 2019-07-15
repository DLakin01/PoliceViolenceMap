using System;
using System.Collections.Generic;

namespace PoliceViolenceMap.Models
{
    public partial class PoliceKillings
    {
        public double IncidentId { get; set; }
        public string VictimSName { get; set; }
        public double? VictimSAge { get; set; }
        public string VictimSGender { get; set; }
        public string VictimSRace { get; set; }
        public string UrlOfImageOfVictim { get; set; }
        public DateTime? DateOfIncidentMonthDayYear { get; set; }
        public string StreetAddressOfIncident { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public double? Zipcode { get; set; }
        public string County { get; set; }
        public string AgencyResponsibleForDeath { get; set; }
        public string CauseOfDeath { get; set; }
        public string ABriefDescriptionOfTheCircumstancesSurroundingTheDeath { get; set; }
        public string OfficialDispositionOfDeathJustifiedOrOther { get; set; }
        public string CriminalCharges { get; set; }
        public string LinkToNewsArticleOrPhotoOfOfficialDocument { get; set; }
        public string SymptomsOfMentalIllness { get; set; }
        public string Unarmed { get; set; }
        public string AllegedWeaponSourceWaPo { get; set; }
        public string AllegedThreatLevelSourceWaPo { get; set; }
        public string FleeingSourceWaPo { get; set; }
        public string BodyCameraSourceWaPo { get; set; }
        public double? WaPoIdIfIncludedInWaPoDatabase { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
