﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecruiterWorkflow.Data;

#nullable disable

namespace RecruiterWorkflow.Migrations
{
    [DbContext(typeof(RecruiterWorkflowContext))]
    [Migration("20250101172630_ResetAndSeedData")]
    partial class ResetAndSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecruiterWorkflow.Models.Availability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int>("DayofWeek")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Availibility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Occupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialty")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "johndoe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            Occupation = "Nurse",
                            Phone = "123-456-7890",
                            Specialty = "Pediatrics",
                            State = "California"
                        },
                        new
                        {
                            Id = 2,
                            Email = "janesmith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            Occupation = "Doctor",
                            Phone = "987-654-3210",
                            Specialty = "Cardiology",
                            State = "Texas"
                        });
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Clinic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clinics");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Main St, Cityville",
                            Email = "contact@cityhealth.com",
                            Name = "City Health Clinic"
                        },
                        new
                        {
                            Id = 2,
                            Address = "456 Elm St, Suburbia",
                            Email = "info@suburbcare.com",
                            Name = "Suburb Care Center"
                        });
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Credential", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("ExpirationDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IssueDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Issuer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Credentials");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CandidateId = 1,
                            ExpirationDate = "2024-01-01",
                            IssueDate = "2019-01-01",
                            Issuer = "State Board of Nursing",
                            Name = "RN License"
                        },
                        new
                        {
                            Id = 2,
                            CandidateId = 2,
                            ExpirationDate = "2025-01-01",
                            IssueDate = "2018-01-01",
                            Issuer = "Medical Board",
                            Name = "Board Certification - Cardiology"
                        });
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Experience", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Employer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("End")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Start")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CandidateId = 1,
                            Description = "Worked in pediatrics ward.",
                            Employer = "City General Hospital",
                            End = "2023-01-01",
                            Role = "Nurse",
                            Start = "2020-01-01"
                        },
                        new
                        {
                            Id = 2,
                            CandidateId = 2,
                            Description = "Performed heart surgeries.",
                            Employer = "County Heart Center",
                            End = "2023-06-01",
                            Role = "Cardiologist",
                            Start = "2019-05-01"
                        });
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<string>("CompensationAndBenefits")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedule")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClinicId");

                    b.ToTable("Jobs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClinicId = 1,
                            CompensationAndBenefits = "Competitive salary, health insurance, and retirement benefits.",
                            Description = "Provide patient care in pediatrics.",
                            Duration = "1 year contract",
                            Requirements = "Valid nursing license, 2+ years of pediatric experience.",
                            Responsibilities = "Administer medications, monitor patient recovery, and maintain accurate records.",
                            Title = "Registered Nurse"
                        },
                        new
                        {
                            Id = 2,
                            ClinicId = 2,
                            CompensationAndBenefits = "High salary, malpractice insurance, healthcare benefits, and professional development opportunities.",
                            Description = "Perform heart surgeries and manage patients with cardiovascular diseases.",
                            Duration = "Permanent position",
                            Requirements = "Board certification in cardiology, valid medical license, and 5+ years of experience.",
                            Responsibilities = "Conduct diagnostic tests, perform surgeries, and provide treatment plans for cardiovascular health.",
                            Title = "Cardiologist"
                        });
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("JobId");

                    b.ToTable("Matches", (string)null);
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Position", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.HasIndex("JobId");

                    b.ToTable("Positions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CandidateId = 1,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            CandidateId = 1,
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            CandidateId = 1,
                            Type = 2
                        },
                        new
                        {
                            Id = 4,
                            CandidateId = 1,
                            Type = 3
                        },
                        new
                        {
                            Id = 5,
                            CandidateId = 2,
                            Type = 0
                        },
                        new
                        {
                            Id = 6,
                            CandidateId = 2,
                            Type = 2
                        },
                        new
                        {
                            Id = 7,
                            CandidateId = 2,
                            Type = 3
                        },
                        new
                        {
                            Id = 8,
                            JobId = 1,
                            Type = 0
                        });
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CandidateId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CandidateId");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CandidateId = 1,
                            Name = "Pediatric Care"
                        },
                        new
                        {
                            Id = 2,
                            CandidateId = 2,
                            Name = "Surgical Procedures"
                        });
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Availability", b =>
                {
                    b.HasOne("RecruiterWorkflow.Models.Candidate", "Candidate")
                        .WithMany("Availabilities")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Credential", b =>
                {
                    b.HasOne("RecruiterWorkflow.Models.Candidate", "Candidate")
                        .WithMany("Credentials")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Experience", b =>
                {
                    b.HasOne("RecruiterWorkflow.Models.Candidate", "Candidate")
                        .WithMany("Experiences")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Job", b =>
                {
                    b.HasOne("RecruiterWorkflow.Models.Clinic", "Clinic")
                        .WithMany("Jobs")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Match", b =>
                {
                    b.HasOne("RecruiterWorkflow.Models.Candidate", "Candidate")
                        .WithMany("Matches")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RecruiterWorkflow.Models.Job", "Job")
                        .WithMany("Matches")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Candidate");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Position", b =>
                {
                    b.HasOne("RecruiterWorkflow.Models.Candidate", "Candidate")
                        .WithMany("Positions")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RecruiterWorkflow.Models.Job", "Job")
                        .WithMany("AvailablePositions")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Candidate");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Skill", b =>
                {
                    b.HasOne("RecruiterWorkflow.Models.Candidate", "Candidate")
                        .WithMany("Skills")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Candidate", b =>
                {
                    b.Navigation("Availabilities");

                    b.Navigation("Credentials");

                    b.Navigation("Experiences");

                    b.Navigation("Matches");

                    b.Navigation("Positions");

                    b.Navigation("Skills");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Clinic", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("RecruiterWorkflow.Models.Job", b =>
                {
                    b.Navigation("AvailablePositions");

                    b.Navigation("Matches");
                });
#pragma warning restore 612, 618
        }
    }
}
