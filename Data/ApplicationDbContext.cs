using DrivingClass.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrivingClass.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
