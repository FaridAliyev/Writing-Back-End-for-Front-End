﻿// <auto-generated />
using System;
using ASPNetProject.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNetProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200707224029_AddedTestimonialTable")]
    partial class AddedTestimonialTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNetProject.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("About");
                });

            modelBuilder.Entity("ASPNetProject.Models.Background", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Backgrounds");
                });

            modelBuilder.Entity("ASPNetProject.Models.Bio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("ContactMail")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Facebook")
                        .HasMaxLength(100);

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasMaxLength(50);

                    b.Property<string>("Pinterest")
                        .HasMaxLength(100);

                    b.Property<string>("Twitter")
                        .HasMaxLength(100);

                    b.Property<string>("Vimeo")
                        .HasMaxLength(100);

                    b.Property<string>("Website")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Bios");
                });

            modelBuilder.Entity("ASPNetProject.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("PostedBy")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Quote")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Blogs");
                });

            modelBuilder.Entity("ASPNetProject.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ASPNetProject.Models.CourseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .HasMaxLength(700);

                    b.Property<string>("Certification")
                        .HasMaxLength(700);

                    b.Property<int>("CourseId");

                    b.Property<string>("HowToApply")
                        .HasMaxLength(700);

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("CourseDetails");
                });

            modelBuilder.Entity("ASPNetProject.Models.CourseFeature", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Assesments")
                        .HasMaxLength(200);

                    b.Property<int>("ClassDuration");

                    b.Property<int>("CourseId");

                    b.Property<string>("Duration")
                        .HasMaxLength(200);

                    b.Property<int>("Fee");

                    b.Property<string>("Language")
                        .HasMaxLength(200);

                    b.Property<string>("SkillLevel")
                        .HasMaxLength(200);

                    b.Property<DateTime>("StartDate");

                    b.Property<int>("StudentCount");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("CourseFeatures");
                });

            modelBuilder.Entity("ASPNetProject.Models.Degree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("ASPNetProject.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(700);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Venue")
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("ASPNetProject.Models.EventSpeaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EventId");

                    b.Property<int>("SpeakerId");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("EventSpeakers");
                });

            modelBuilder.Entity("ASPNetProject.Models.Faculty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("ASPNetProject.Models.Hobbie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("ASPNetProject.Models.NoticeBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("NoticeBoards");
                });

            modelBuilder.Entity("ASPNetProject.Models.NoticeVideo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("NoticeVideos");
                });

            modelBuilder.Entity("ASPNetProject.Models.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("ASPNetProject.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Communication");

                    b.Property<int>("Design");

                    b.Property<int>("Development");

                    b.Property<int>("Innovation");

                    b.Property<int>("Language");

                    b.Property<int>("TeamLeader");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("ASPNetProject.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Sliders");
                });

            modelBuilder.Entity("ASPNetProject.Models.SliderText", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("SliderContents");
                });

            modelBuilder.Entity("ASPNetProject.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Duty")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("ASPNetProject.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FacultyId");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<int>("SkillId");

                    b.HasKey("Id");

                    b.HasIndex("FacultyId");

                    b.HasIndex("SkillId")
                        .IsUnique();

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ASPNetProject.Models.TeacherDegree", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DegreeId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("DegreeId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherDegrees");
                });

            modelBuilder.Entity("ASPNetProject.Models.TeacherHobbie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HobbieId");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("HobbieId");

                    b.HasIndex("TeacherId");

                    b.ToTable("TeacherHobbies");
                });

            modelBuilder.Entity("ASPNetProject.Models.TeacherInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(800);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("ExperienceYear");

                    b.Property<string>("Facebook")
                        .HasMaxLength(200);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Pinterest")
                        .HasMaxLength(200);

                    b.Property<string>("Qualification")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Skype")
                        .HasMaxLength(200);

                    b.Property<int>("TeacherId");

                    b.Property<string>("Twitter")
                        .HasMaxLength(200);

                    b.Property<string>("Vimeo")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("TeacherId")
                        .IsUnique();

                    b.ToTable("TeacherInfos");
                });

            modelBuilder.Entity("ASPNetProject.Models.Testimonial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Duty")
                        .HasMaxLength(200);

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<string>("Qualification")
                        .HasMaxLength(200);

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Testimonials");
                });

            modelBuilder.Entity("ASPNetProject.Models.CourseDetail", b =>
                {
                    b.HasOne("ASPNetProject.Models.Course", "Course")
                        .WithOne("CourseDetail")
                        .HasForeignKey("ASPNetProject.Models.CourseDetail", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetProject.Models.CourseFeature", b =>
                {
                    b.HasOne("ASPNetProject.Models.Course", "Course")
                        .WithOne("CourseFeature")
                        .HasForeignKey("ASPNetProject.Models.CourseFeature", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetProject.Models.EventSpeaker", b =>
                {
                    b.HasOne("ASPNetProject.Models.Event", "Event")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNetProject.Models.Speaker", "Speaker")
                        .WithMany("EventSpeakers")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetProject.Models.Teacher", b =>
                {
                    b.HasOne("ASPNetProject.Models.Faculty", "Faculty")
                        .WithMany("Teachers")
                        .HasForeignKey("FacultyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNetProject.Models.Skill", "Skill")
                        .WithOne("Teacher")
                        .HasForeignKey("ASPNetProject.Models.Teacher", "SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetProject.Models.TeacherDegree", b =>
                {
                    b.HasOne("ASPNetProject.Models.Degree", "Degree")
                        .WithMany("TeacherDegrees")
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNetProject.Models.Teacher", "Teacher")
                        .WithMany("TeacherDegrees")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetProject.Models.TeacherHobbie", b =>
                {
                    b.HasOne("ASPNetProject.Models.Hobbie", "Hobbie")
                        .WithMany("TeacherHobbies")
                        .HasForeignKey("HobbieId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNetProject.Models.Teacher", "Teacher")
                        .WithMany("TeacherHobbies")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ASPNetProject.Models.TeacherInfo", b =>
                {
                    b.HasOne("ASPNetProject.Models.Teacher", "Teacher")
                        .WithOne("TeacherInfo")
                        .HasForeignKey("ASPNetProject.Models.TeacherInfo", "TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
