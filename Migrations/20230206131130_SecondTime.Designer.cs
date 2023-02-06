﻿// <auto-generated />
using System;
using AssignmentNo1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AssignmentNo1.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230206131130_SecondTime")]
    partial class SecondTime
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("AssignmentNo1.Models.Exam", b =>
                {
                    b.Property<long>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<long>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExamId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("AssignmentNo1.Models.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Address = "Hanoi",
                            DateOfBirth = new DateOnly(2003, 12, 2),
                            Email = "johndoe@gmail.com",
                            Name = "John 321421"
                        },
                        new
                        {
                            Id = 2L,
                            Address = "Hanoi",
                            DateOfBirth = new DateOnly(2008, 10, 2),
                            Email = "cuan@gmail.com",
                            Name = "Quan sad aw"
                        },
                        new
                        {
                            Id = 3L,
                            Address = "Hanoi",
                            DateOfBirth = new DateOnly(2002, 12, 2),
                            Email = "hiu@gmail.com",
                            Name = "Hieu huhuh"
                        });
                });

            modelBuilder.Entity("AssignmentNo1.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectCode")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("TEXT");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            SubjectId = 1,
                            Description = "Ooi khoongggggggggggg",
                            EndDate = new DateOnly(2022, 2, 12),
                            StartDate = new DateOnly(2021, 12, 2),
                            SubjectCode = "273604",
                            SubjectName = "Math Algebra"
                        },
                        new
                        {
                            SubjectId = 2,
                            Description = "Ooi khoongggggggggggg",
                            EndDate = new DateOnly(2022, 2, 12),
                            StartDate = new DateOnly(2021, 12, 2),
                            SubjectCode = "273605",
                            SubjectName = "Math2 Algebra"
                        },
                        new
                        {
                            SubjectId = 3,
                            Description = "Ooi khoongggggggggggg",
                            EndDate = new DateOnly(2022, 2, 12),
                            StartDate = new DateOnly(2021, 12, 2),
                            SubjectCode = "273606",
                            SubjectName = "Math Algebra"
                        });
                });

            modelBuilder.Entity("AssignmentNo1.Models.Exam", b =>
                {
                    b.HasOne("AssignmentNo1.Models.Student", "Student")
                        .WithMany("Exams")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AssignmentNo1.Models.Subject", "Subject")
                        .WithMany("Exams")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AssignmentNo1.Models.Student", b =>
                {
                    b.Navigation("Exams");
                });

            modelBuilder.Entity("AssignmentNo1.Models.Subject", b =>
                {
                    b.Navigation("Exams");
                });
#pragma warning restore 612, 618
        }
    }
}
