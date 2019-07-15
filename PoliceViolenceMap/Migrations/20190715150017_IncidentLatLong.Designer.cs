﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PoliceViolenceMap.Models;

namespace PoliceViolenceMap.Migrations
{
    [DbContext(typeof(PoliceViolenceContext))]
    [Migration("20190715150017_IncidentLatLong")]
    partial class IncidentLatLong
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PoliceViolenceMap.Models.KillingsByState", b =>
                {
                    b.Property<double>("StateId");

                    b.Property<double?>("AfricanAmerican")
                        .HasColumnName("% African-American");

                    b.Property<double?>("AfricanAmericanAlone")
                        .HasColumnName("African-American Alone");

                    b.Property<double?>("AsianPeopleKilled")
                        .HasColumnName("# Asian people killed");

                    b.Property<double?>("BlackPeopleKilled")
                        .HasColumnName("# Black people killed");

                    b.Property<double?>("Disparity");

                    b.Property<string>("F18")
                        .HasMaxLength(255);

                    b.Property<double?>("HispanicPeopleKilled")
                        .HasColumnName("# Hispanic people killed");

                    b.Property<double?>("NativeAmericanPeopleKilled")
                        .HasColumnName("# Native American people killed");

                    b.Property<double?>("PacificIslandersKilled")
                        .HasColumnName("# Pacific Islanders killed");

                    b.Property<double?>("PeopleKilled")
                        .HasColumnName("# People Killed");

                    b.Property<double?>("Population");

                    b.Property<double?>("RateAllPeople")
                        .HasColumnName("Rate (All People)");

                    b.Property<double?>("RateBlackPeople")
                        .HasColumnName("Rate (Black People)");

                    b.Property<string>("State")
                        .HasMaxLength(255);

                    b.Property<double?>("UnknownRacePeopleKilled")
                        .HasColumnName("# Unknown Race people killed");

                    b.Property<double?>("VictimsBlack")
                        .HasColumnName("% Victims Black");

                    b.Property<double?>("WhitePeopleKilled")
                        .HasColumnName("# White people killed");

                    b.HasKey("StateId")
                        .HasName("PK_KillingsByState_StateId");

                    b.ToTable("KillingsByState");
                });

            modelBuilder.Entity("PoliceViolenceMap.Models.PoliceKillings", b =>
                {
                    b.Property<double>("IncidentId");

                    b.Property<string>("ABriefDescriptionOfTheCircumstancesSurroundingTheDeath")
                        .HasColumnName("A brief description of the circumstances surrounding the death");

                    b.Property<string>("AgencyResponsibleForDeath")
                        .HasColumnName("Agency responsible for death")
                        .HasMaxLength(255);

                    b.Property<string>("AllegedThreatLevelSourceWaPo")
                        .HasColumnName("Alleged Threat Level (Source: WaPo)")
                        .HasMaxLength(255);

                    b.Property<string>("AllegedWeaponSourceWaPo")
                        .HasColumnName("Alleged Weapon (Source: WaPo)")
                        .HasMaxLength(255);

                    b.Property<string>("BodyCameraSourceWaPo")
                        .HasColumnName("Body Camera (Source: WaPo)")
                        .HasMaxLength(255);

                    b.Property<string>("CauseOfDeath")
                        .HasColumnName("Cause of death")
                        .HasMaxLength(255);

                    b.Property<string>("City")
                        .HasMaxLength(255);

                    b.Property<string>("County")
                        .HasMaxLength(255);

                    b.Property<string>("CriminalCharges")
                        .HasColumnName("Criminal Charges?")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("DateOfIncidentMonthDayYear")
                        .HasColumnName("Date of Incident (month/day/year)")
                        .HasColumnType("datetime");

                    b.Property<string>("FleeingSourceWaPo")
                        .HasColumnName("Fleeing (Source: WaPo)")
                        .HasMaxLength(255);

                    b.Property<string>("Latitude");

                    b.Property<string>("LinkToNewsArticleOrPhotoOfOfficialDocument")
                        .HasColumnName("Link to news article or photo of official document")
                        .HasMaxLength(255);

                    b.Property<string>("Longitude");

                    b.Property<string>("OfficialDispositionOfDeathJustifiedOrOther")
                        .HasColumnName("Official disposition of death (justified or other)")
                        .HasMaxLength(255);

                    b.Property<string>("State")
                        .HasMaxLength(255);

                    b.Property<string>("StreetAddressOfIncident")
                        .HasColumnName("Street Address of Incident")
                        .HasMaxLength(255);

                    b.Property<string>("SymptomsOfMentalIllness")
                        .HasColumnName("Symptoms of mental illness?")
                        .HasMaxLength(255);

                    b.Property<string>("Unarmed")
                        .HasMaxLength(255);

                    b.Property<string>("UrlOfImageOfVictim")
                        .HasColumnName("URL of image of victim")
                        .HasMaxLength(255);

                    b.Property<double?>("VictimSAge")
                        .HasColumnName("Victim's age");

                    b.Property<string>("VictimSGender")
                        .HasColumnName("Victim's gender")
                        .HasMaxLength(255);

                    b.Property<string>("VictimSName")
                        .HasColumnName("Victim's name")
                        .HasMaxLength(255);

                    b.Property<string>("VictimSRace")
                        .HasColumnName("Victim's race")
                        .HasMaxLength(255);

                    b.Property<double?>("WaPoIdIfIncludedInWaPoDatabase")
                        .HasColumnName("WaPo ID (If included in WaPo database)");

                    b.Property<double?>("Zipcode");

                    b.HasKey("IncidentId")
                        .HasName("PK_PoliceKillings_IncidentId");

                    b.ToTable("PoliceKillings");
                });

            modelBuilder.Entity("PoliceViolenceMap.Models.PoliceKillingsOfBlackMen", b =>
                {
                    b.Property<double>("IncidentId");

                    b.Property<double?>("AveragePoliceHomicideRateForBlackMenPer100000")
                        .HasColumnName("Average Police Homicide Rate for Black Men (per 100,000)");

                    b.Property<double?>("BlackMalePopulation2015Acs")
                        .HasColumnName("Black Male Population (2015 ACS)");

                    b.Property<double?>("BlackMenKilledByPolice11201312312017")
                        .HasColumnName("Black Men Killed by Police (1/1/2013-12/31/2017)");

                    b.Property<string>("City")
                        .HasMaxLength(255);

                    b.Property<string>("Pd")
                        .HasColumnName("PD")
                        .HasMaxLength(255);

                    b.HasKey("IncidentId")
                        .HasName("PK_PoliceKillingsOfBlackMen_IncidentId");

                    b.ToTable("PoliceKillingsOfBlackMen");
                });
#pragma warning restore 612, 618
        }
    }
}
