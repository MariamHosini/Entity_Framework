﻿// <auto-generated />
using System;
using DB.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DB.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DB.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"));

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("ManagerID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentID = 1,
                            Location = "Building A",
                            Name = "Computer Science"
                        },
                        new
                        {
                            DepartmentID = 2,
                            Location = "Building B",
                            ManagerID = 102,
                            Name = "Mathematics"
                        },
                        new
                        {
                            DepartmentID = 3,
                            Location = "Building C",
                            ManagerID = 103,
                            Name = "Physics"
                        });
                });

            modelBuilder.Entity("DB.Instructor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Instructors");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            DepartmentID = 1,
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            ID = 102,
                            DepartmentID = 2,
                            FirstName = "Bob",
                            LastName = "Smith",
                            Phone = "987-654-3210"
                        },
                        new
                        {
                            ID = 103,
                            DepartmentID = 3,
                            FirstName = "Charlie",
                            LastName = "Davis",
                            Phone = "555-666-7777"
                        });
                });

            modelBuilder.Entity("DB.Modelss.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("InstructorID");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            DepartmentID = 1,
                            Duration = 40,
                            InstructorID = 101,
                            Name = "C# Programming"
                        },
                        new
                        {
                            ID = 2,
                            DepartmentID = 1,
                            Duration = 35,
                            InstructorID = 101,
                            Name = "Java Programming"
                        },
                        new
                        {
                            ID = 3,
                            DepartmentID = 2,
                            Duration = 30,
                            InstructorID = 102,
                            Name = "Algebra"
                        },
                        new
                        {
                            ID = 4,
                            DepartmentID = 3,
                            Duration = 45,
                            InstructorID = 103,
                            Name = "Quantum Physics"
                        });
                });

            modelBuilder.Entity("DB.Modelss.CourseSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InstructorID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("InstructorID");

                    b.ToTable("CoursesSessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseID = 1,
                            Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorID = 101,
                            Title = "Intro to C#"
                        },
                        new
                        {
                            Id = 2,
                            CourseID = 1,
                            Date = new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorID = 101,
                            Title = "Advanced C#"
                        },
                        new
                        {
                            Id = 3,
                            CourseID = 2,
                            Date = new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorID = 101,
                            Title = "Java Basics"
                        },
                        new
                        {
                            Id = 4,
                            CourseID = 3,
                            Date = new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorID = 102,
                            Title = "Linear Algebra"
                        },
                        new
                        {
                            Id = 5,
                            CourseID = 4,
                            Date = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            InstructorID = 103,
                            Title = "Quantum Mechanics"
                        });
                });

            modelBuilder.Entity("DB.Modelss.CourseSessionAttendance", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("CourseSessionID")
                        .HasColumnType("int");

                    b.Property<int>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseSessionID");

                    b.HasIndex("StudentID");

                    b.ToTable("CourseSessionAttendances");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CourseSessionID = 1,
                            Grade = 90,
                            Note = "Excellent",
                            StudentID = 1
                        },
                        new
                        {
                            ID = 2,
                            CourseSessionID = 1,
                            Grade = 85,
                            Note = "Good",
                            StudentID = 2
                        },
                        new
                        {
                            ID = 3,
                            CourseSessionID = 2,
                            Grade = 95,
                            Note = "Outstanding",
                            StudentID = 1
                        },
                        new
                        {
                            ID = 4,
                            CourseSessionID = 3,
                            Grade = 80,
                            Note = "Satisfactory",
                            StudentID = 3
                        },
                        new
                        {
                            ID = 5,
                            CourseSessionID = 4,
                            Grade = 70,
                            Note = "Needs Improvement",
                            StudentID = 4
                        });
                });

            modelBuilder.Entity("DB.Modelss.Course_Student", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("Course_Students");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            CourseID = 1
                        },
                        new
                        {
                            StudentID = 2,
                            CourseID = 1
                        },
                        new
                        {
                            StudentID = 3,
                            CourseID = 2
                        },
                        new
                        {
                            StudentID = 4,
                            CourseID = 3
                        },
                        new
                        {
                            StudentID = 1,
                            CourseID = 4
                        },
                        new
                        {
                            StudentID = 2,
                            CourseID = 4
                        });
                });

            modelBuilder.Entity("DB.Modelss.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            FirstName = "John",
                            LastName = "Doe",
                            Phone = "111-222-3333"
                        },
                        new
                        {
                            ID = 2,
                            FirstName = "Jane",
                            LastName = "Smith",
                            Phone = "444-555-6666"
                        },
                        new
                        {
                            ID = 3,
                            FirstName = "Michael",
                            LastName = "Brown",
                            Phone = "777-888-9999"
                        },
                        new
                        {
                            ID = 4,
                            FirstName = "Emily",
                            LastName = "Davis",
                            Phone = "000-111-2222"
                        });
                });

            modelBuilder.Entity("DB.Instructor", b =>
                {
                    b.HasOne("DB.Department", "Department")
                        .WithMany("instructors")
                        .HasForeignKey("DepartmentID");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("DB.Modelss.Course", b =>
                {
                    b.HasOne("DB.Department", "Department")
                        .WithMany("courses")
                        .HasForeignKey("DepartmentID");

                    b.HasOne("DB.Instructor", "Instructor")
                        .WithMany("courses")
                        .HasForeignKey("InstructorID");

                    b.Navigation("Department");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("DB.Modelss.CourseSession", b =>
                {
                    b.HasOne("DB.Modelss.Course", "course")
                        .WithMany("courseSessions")
                        .HasForeignKey("CourseID");

                    b.HasOne("DB.Instructor", "Instructor")
                        .WithMany("courseSessions")
                        .HasForeignKey("InstructorID");

                    b.Navigation("Instructor");

                    b.Navigation("course");
                });

            modelBuilder.Entity("DB.Modelss.CourseSessionAttendance", b =>
                {
                    b.HasOne("DB.Modelss.CourseSession", "CourseSession")
                        .WithMany("Attendances")
                        .HasForeignKey("CourseSessionID");

                    b.HasOne("DB.Modelss.Student", "student")
                        .WithMany("Attendances")
                        .HasForeignKey("StudentID");

                    b.Navigation("CourseSession");

                    b.Navigation("student");
                });

            modelBuilder.Entity("DB.Modelss.Course_Student", b =>
                {
                    b.HasOne("DB.Modelss.Course", "course")
                        .WithMany("course_Students")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DB.Modelss.Student", "student")
                        .WithMany("course_Students")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("student");
                });

            modelBuilder.Entity("DB.Department", b =>
                {
                    b.Navigation("courses");

                    b.Navigation("instructors");
                });

            modelBuilder.Entity("DB.Instructor", b =>
                {
                    b.Navigation("courseSessions");

                    b.Navigation("courses");
                });

            modelBuilder.Entity("DB.Modelss.Course", b =>
                {
                    b.Navigation("courseSessions");

                    b.Navigation("course_Students");
                });

            modelBuilder.Entity("DB.Modelss.CourseSession", b =>
                {
                    b.Navigation("Attendances");
                });

            modelBuilder.Entity("DB.Modelss.Student", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("course_Students");
                });
#pragma warning restore 612, 618
        }
    }
}
