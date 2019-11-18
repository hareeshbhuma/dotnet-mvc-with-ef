using Microsoft.EntityFrameworkCore;
using demotest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demotest.Data
{
        public class SchoolDbContext : DbContext
        {
            public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
            {
            }

            public DbSet<Course> Courses { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Student> Students { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {


                modelBuilder.Entity<Course>().ToTable("Course");
                modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
                modelBuilder.Entity<Student>().ToTable("Student");
             
            }

        }
 }

