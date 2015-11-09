using HealthyJourney.Data.Configurations;
using HealthyJourney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyJourney.Data
{
    public class HealthyJourneyContext : DbContext
    {

        public HealthyJourneyContext() : base("Name=HealthyJourneyConnection")
        {

        }

        public DbSet<User> Users { get; set; }
       

        public DbSet<Badge> Badges { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<MedicalCenterMetadata> MedicalCenterMetadatas { get; set; }
        public DbSet<ServiceProviderBadge> ServiceProviderBadges { get; set; }

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
           
      /*      modelBuilder.Entity<ServiceProvider>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("ServiceProviders");
                
            }); */

        }

    }
}
