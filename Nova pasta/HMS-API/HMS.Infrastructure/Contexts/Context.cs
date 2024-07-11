using HMS.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HMS.Infrastructure.Contexts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public Context()
        {
        }
        string connection = @"
        Data source=DESKTOP-02H8VMC; 
        database=HealthManagementSystem; 
        Trusted_Connection=true;Encrypt=false; 
        TrustServerCertificate=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Patient
            modelBuilder.Entity<PatientEntity>()
                .HasIndex(e => e.CPF)
                .IsUnique();
            modelBuilder.Entity<PatientEntity>()
                .Property(e => e.CreatedAt)
                .ValueGeneratedOnAdd()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);

            /*modelBuilder.Entity<PatientEntity>()
            //.Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
                .Property(e => e.UpdatedAt)
                .HasDefaultValue(DateTime.UtcNow)
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);*/

            //Employee
            modelBuilder.Entity<EmployeeEntity>()
                .HasIndex(e => e.CPF)
                .IsUnique();
            modelBuilder.Entity<EmployeeEntity>()
                .HasIndex(e => e.SocialIntegrationProgramNumber)
                .IsUnique();
            modelBuilder.Entity<EmployeeEntity>()
                .Property(e => e.SocialIntegrationProgramNumber)
                .IsRequired();
            modelBuilder.Entity<EmployeeEntity>()
                .Property(e => e.CreatedAt)
                .ValueGeneratedOnAdd()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            /*modelBuilder.Entity<EmployeeEntity>()
                .Property(e => e.UpdatedAt)
                .HasDefaultValue(DateTime.Now.ToLocalTime())
                .ValueGeneratedOnAddOrUpdate();*/


            modelBuilder.Entity<EmployeeEntity>()
                    .Property(e => e.CreatedAt)
                .HasDefaultValue(DateTime.Now.ToLocalTime())
                .ValueGeneratedOnAdd()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);


            base.OnModelCreating(modelBuilder);

        }

        /*        public Context()
                {

                }
                string connection = @"Data source=DESKTOP-02H8VMC; 
                        database=HealthManagementSystem; 
                        Trusted_Connection=true;Encrypt=false; 
                        TrustServerCertificate=true";
                protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                {
                    optionsBuilder.UseSqlServer(connection);
                }*/
        public DbSet<PatientEntity> Patients { get; set; }
        public DbSet<EmployeeEntity> Employees { get; set; }
    }
}
