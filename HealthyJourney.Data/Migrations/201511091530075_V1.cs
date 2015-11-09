namespace HealthyJourney.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Badges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                        DateCreation = c.DateTime(nullable: false),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        ForumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClientId, t.ForumId })
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Fora", t => t.ForumId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.ForumId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        username = c.String(nullable: false, maxLength: 8),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false, maxLength: 8),
                        IsApproved = c.Boolean(nullable: false),
                        Thumbnail = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        Adress_City = c.String(),
                        Adress_Street = c.String(),
                        Adress_Postal = c.String(),
                        Adress_Longitude = c.String(),
                        Adress_Latitude = c.String(),
                        Discriminator = c.String(maxLength: 128),
                        badge_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Badges", t => t.badge_Id)
                .Index(t => t.badge_Id);
            
            CreateTable(
                "dbo.Fora",
                c => new
                    {
                        ForumId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ForumId);
            
            CreateTable(
                "dbo.Consultations",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ClientId, t.DoctorId })
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .ForeignKey("dbo.Doctors", t => t.DoctorId)
                .Index(t => t.ClientId)
                .Index(t => t.DoctorId);
            
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        ServiceId = c.Int(nullable: false),
                        FormularId = c.Int(nullable: false),
                        Client_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.ServiceId, t.FormularId })
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Formulars", t => t.FormularId, cascadeDelete: true)
                .Index(t => t.FormularId)
                .Index(t => t.Client_Id);
            
            CreateTable(
                "dbo.Formulars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FeedBacks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(),
                        Title = c.String(),
                        Descripion = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.ClientId)
                .Index(t => t.ClientId);
            
            CreateTable(
                "dbo.MedicalCenterMetadatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        file = c.String(),
                        MedicalCenter_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MedicalCenters", t => t.MedicalCenter_Id)
                .Index(t => t.MedicalCenter_Id);
            
            CreateTable(
                "dbo.MedicalRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(nullable: false),
                        Description = c.String(nullable: false),
                        Client_Id = c.Int(),
                        speciality_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.Badges", t => t.speciality_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.speciality_Id);
            
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ServiceProviderBadges",
                c => new
                    {
                        BadgeId = c.Int(nullable: false),
                        ServiceProviderId = c.Int(nullable: false),
                        DateObtention = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.BadgeId, t.ServiceProviderId })
                .ForeignKey("dbo.Badges", t => t.BadgeId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.ServiceProviderId, cascadeDelete: true)
                .Index(t => t.BadgeId)
                .Index(t => t.ServiceProviderId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                        ImgPath = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Consultants",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        LastName = c.String(),
                        FirstName = c.String(),
                        Age = c.Int(nullable: false),
                        Country = c.String(),
                        Language = c.String(),
                        Currency = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.MedicalCenters",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Doctors", "Id", "dbo.Users");
            DropForeignKey("dbo.Insurances", "Id", "dbo.Users");
            DropForeignKey("dbo.MedicalCenters", "Id", "dbo.Users");
            DropForeignKey("dbo.Clients", "Id", "dbo.Users");
            DropForeignKey("dbo.Consultants", "Id", "dbo.Users");
            DropForeignKey("dbo.Admins", "Id", "dbo.Users");
            DropForeignKey("dbo.ServiceProviderBadges", "ServiceProviderId", "dbo.Users");
            DropForeignKey("dbo.Users", "badge_Id", "dbo.Badges");
            DropForeignKey("dbo.ServiceProviderBadges", "BadgeId", "dbo.Badges");
            DropForeignKey("dbo.MedicalRecords", "speciality_Id", "dbo.Badges");
            DropForeignKey("dbo.MedicalRecords", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.MedicalCenterMetadatas", "MedicalCenter_Id", "dbo.MedicalCenters");
            DropForeignKey("dbo.FeedBacks", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Factures", "FormularId", "dbo.Formulars");
            DropForeignKey("dbo.Factures", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Consultations", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Consultations", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Comments", "ForumId", "dbo.Fora");
            DropForeignKey("dbo.Comments", "ClientId", "dbo.Clients");
            DropIndex("dbo.Doctors", new[] { "Id" });
            DropIndex("dbo.Insurances", new[] { "Id" });
            DropIndex("dbo.MedicalCenters", new[] { "Id" });
            DropIndex("dbo.Clients", new[] { "Id" });
            DropIndex("dbo.Consultants", new[] { "Id" });
            DropIndex("dbo.Admins", new[] { "Id" });
            DropIndex("dbo.ServiceProviderBadges", new[] { "ServiceProviderId" });
            DropIndex("dbo.ServiceProviderBadges", new[] { "BadgeId" });
            DropIndex("dbo.MedicalRecords", new[] { "speciality_Id" });
            DropIndex("dbo.MedicalRecords", new[] { "Client_Id" });
            DropIndex("dbo.MedicalCenterMetadatas", new[] { "MedicalCenter_Id" });
            DropIndex("dbo.FeedBacks", new[] { "ClientId" });
            DropIndex("dbo.Factures", new[] { "Client_Id" });
            DropIndex("dbo.Factures", new[] { "FormularId" });
            DropIndex("dbo.Consultations", new[] { "DoctorId" });
            DropIndex("dbo.Consultations", new[] { "ClientId" });
            DropIndex("dbo.Users", new[] { "badge_Id" });
            DropIndex("dbo.Comments", new[] { "ForumId" });
            DropIndex("dbo.Comments", new[] { "ClientId" });
            DropTable("dbo.Doctors");
            DropTable("dbo.Insurances");
            DropTable("dbo.MedicalCenters");
            DropTable("dbo.Clients");
            DropTable("dbo.Consultants");
            DropTable("dbo.Admins");
            DropTable("dbo.Specialities");
            DropTable("dbo.Services");
            DropTable("dbo.ServiceProviderBadges");
            DropTable("dbo.News");
            DropTable("dbo.MedicalRecords");
            DropTable("dbo.MedicalCenterMetadatas");
            DropTable("dbo.FeedBacks");
            DropTable("dbo.Formulars");
            DropTable("dbo.Factures");
            DropTable("dbo.Consultations");
            DropTable("dbo.Fora");
            DropTable("dbo.Users");
            DropTable("dbo.Comments");
            DropTable("dbo.Badges");
        }
    }
}
