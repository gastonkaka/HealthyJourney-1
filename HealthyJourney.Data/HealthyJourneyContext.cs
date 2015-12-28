using HealthyJourney.Data.Configurations;
using HealthyJourney.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data
{
    public class HealthyJourneyContext : IdentityDbContext<User>
    {

        public HealthyJourneyContext() : base("Name=HealthyJourneyConnection")
        {

        }

       // public DbSet<User> Users { get; set; }
       

        public DbSet<Badge> Badges { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Infos> Infos { get; set; }
        public DbSet<InfosSpeciality> InfosSpecialities { get; set; }
        public DbSet<UserMetadata> MedicalCenterMetadatas { get; set; }
        public DbSet<UserBadge> ServiceProviderBadges { get; set; }

        public DbSet<Formular> Formulars { get; set; }
        public DbSet<Service> Services { get; set; }

        public DbSet<FeedBack> Feedbacks { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Forum> Forums { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.Configurations.Add(new UserConfiguration());
            // Configure User as PK for Infos
            modelBuilder.Entity<Infos>()
                .HasKey(e => e.UserId);

            // Configure User as FK for Infos
            //modelBuilder.Entity<User>()
            //            .HasOptional(s => s.Infos) // Mark StudentAddress is optional for Student
            //            .WithRequired(ad => ad.User); // Create inverse relationship
            //// modelBuilder.Entity<User>().HasRequired(t=>t.Email);
            base.OnModelCreating(modelBuilder);

        }

    }
}
