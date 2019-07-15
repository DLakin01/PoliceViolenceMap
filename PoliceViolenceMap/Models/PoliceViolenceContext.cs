using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PoliceViolenceMap.Models
{
    public partial class PoliceViolenceContext : DbContext
    {
        public PoliceViolenceContext()
        {
        }

        public PoliceViolenceContext(DbContextOptions<PoliceViolenceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KillingsByState> KillingsByState { get; set; }
        public virtual DbSet<PoliceKillings> PoliceKillings { get; set; }
        public virtual DbSet<PoliceKillingsOfBlackMen> PoliceKillingsOfBlackMen { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<KillingsByState>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK_KillingsByState_StateId");

                entity.Property(e => e.AfricanAmerican).HasColumnName("% African-American");

                entity.Property(e => e.AfricanAmericanAlone).HasColumnName("African-American Alone");

                entity.Property(e => e.AsianPeopleKilled).HasColumnName("# Asian people killed");

                entity.Property(e => e.BlackPeopleKilled).HasColumnName("# Black people killed");

                entity.Property(e => e.F18).HasMaxLength(255);

                entity.Property(e => e.HispanicPeopleKilled).HasColumnName("# Hispanic people killed");

                entity.Property(e => e.NativeAmericanPeopleKilled).HasColumnName("# Native American people killed");

                entity.Property(e => e.PacificIslandersKilled).HasColumnName("# Pacific Islanders killed");

                entity.Property(e => e.PeopleKilled).HasColumnName("# People Killed");

                entity.Property(e => e.RateAllPeople).HasColumnName("Rate (All People)");

                entity.Property(e => e.RateBlackPeople).HasColumnName("Rate (Black People)");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.UnknownRacePeopleKilled).HasColumnName("# Unknown Race people killed");

                entity.Property(e => e.VictimsBlack).HasColumnName("% Victims Black");

                entity.Property(e => e.WhitePeopleKilled).HasColumnName("# White people killed");
            });

            modelBuilder.Entity<PoliceKillings>(entity =>
            {
                entity.HasKey(e => e.IncidentId)
                    .HasName("PK_PoliceKillings_IncidentId");

                entity.Property(e => e.ABriefDescriptionOfTheCircumstancesSurroundingTheDeath).HasColumnName("A brief description of the circumstances surrounding the death");

                entity.Property(e => e.AgencyResponsibleForDeath)
                    .HasColumnName("Agency responsible for death")
                    .HasMaxLength(255);

                entity.Property(e => e.AllegedThreatLevelSourceWaPo)
                    .HasColumnName("Alleged Threat Level (Source: WaPo)")
                    .HasMaxLength(255);

                entity.Property(e => e.AllegedWeaponSourceWaPo)
                    .HasColumnName("Alleged Weapon (Source: WaPo)")
                    .HasMaxLength(255);

                entity.Property(e => e.BodyCameraSourceWaPo)
                    .HasColumnName("Body Camera (Source: WaPo)")
                    .HasMaxLength(255);

                entity.Property(e => e.CauseOfDeath)
                    .HasColumnName("Cause of death")
                    .HasMaxLength(255);

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.County).HasMaxLength(255);

                entity.Property(e => e.CriminalCharges)
                    .HasColumnName("Criminal Charges?")
                    .HasMaxLength(255);

                entity.Property(e => e.DateOfIncidentMonthDayYear)
                    .HasColumnName("Date of Incident (month/day/year)")
                    .HasColumnType("datetime");

                entity.Property(e => e.FleeingSourceWaPo)
                    .HasColumnName("Fleeing (Source: WaPo)")
                    .HasMaxLength(255);

                entity.Property(e => e.LinkToNewsArticleOrPhotoOfOfficialDocument)
                    .HasColumnName("Link to news article or photo of official document")
                    .HasMaxLength(255);

                entity.Property(e => e.OfficialDispositionOfDeathJustifiedOrOther)
                    .HasColumnName("Official disposition of death (justified or other)")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.StreetAddressOfIncident)
                    .HasColumnName("Street Address of Incident")
                    .HasMaxLength(255);

                entity.Property(e => e.SymptomsOfMentalIllness)
                    .HasColumnName("Symptoms of mental illness?")
                    .HasMaxLength(255);

                entity.Property(e => e.Unarmed).HasMaxLength(255);

                entity.Property(e => e.UrlOfImageOfVictim)
                    .HasColumnName("URL of image of victim")
                    .HasMaxLength(255);

                entity.Property(e => e.VictimSAge).HasColumnName("Victim's age");

                entity.Property(e => e.VictimSGender)
                    .HasColumnName("Victim's gender")
                    .HasMaxLength(255);

                entity.Property(e => e.VictimSName)
                    .HasColumnName("Victim's name")
                    .HasMaxLength(255);

                entity.Property(e => e.VictimSRace)
                    .HasColumnName("Victim's race")
                    .HasMaxLength(255);

                entity.Property(e => e.WaPoIdIfIncludedInWaPoDatabase).HasColumnName("WaPo ID (If included in WaPo database)");
            });

            modelBuilder.Entity<PoliceKillingsOfBlackMen>(entity =>
            {
                entity.HasKey(e => e.IncidentId)
                    .HasName("PK_PoliceKillingsOfBlackMen_IncidentId");

                entity.Property(e => e.AveragePoliceHomicideRateForBlackMenPer100000).HasColumnName("Average Police Homicide Rate for Black Men (per 100,000)");

                entity.Property(e => e.BlackMalePopulation2015Acs).HasColumnName("Black Male Population (2015 ACS)");

                entity.Property(e => e.BlackMenKilledByPolice11201312312017).HasColumnName("Black Men Killed by Police (1/1/2013-12/31/2017)");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Pd)
                    .HasColumnName("PD")
                    .HasMaxLength(255);
            });
        }
    }
}
