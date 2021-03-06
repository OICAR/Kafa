﻿using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data.Migrations
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(
            DbContextOptions<SchoolContext> options) : base(
            options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(
            ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>()
                .ToTable("Enrollment");
            modelBuilder.Entity<Student>()
                .ToTable("Student");
        }
    }
}