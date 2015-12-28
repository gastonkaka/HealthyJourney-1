namespace HealthyJourney.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ve : DbMigration
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
                        CommentId = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Files = c.String(),
                        DateCreation = c.DateTime(nullable: false),
                        Forum_ForumId = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Fora", t => t.Forum_ForumId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Forum_ForumId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Fora",
                c => new
                    {
                        ForumId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Files = c.String(),
                        DateCreation = c.DateTime(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ForumId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Consultations",
                c => new
                    {
                        ClientId = c.Int(nullable: false),
                        DoctorId = c.Int(nullable: false),
                        DateCreation = c.DateTime(nullable: false),
                        Client_Id = c.String(maxLength: 128),
                        Doctor_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ClientId, t.DoctorId })
                .ForeignKey("dbo.AspNetUsers", t => t.Client_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Doctor_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.Factures",
                c => new
                    {
                        ServiceId = c.Int(nullable: false),
                        FormularId = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.ServiceId, t.FormularId })
                .ForeignKey("dbo.Formulars", t => t.FormularId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.FormularId)
                .Index(t => t.User_Id);
            
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
                        UserId = c.Int(),
                        Title = c.String(),
                        Descripion = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Infos",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        IsFull = c.Boolean(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Thumbnail = c.String(),
                        Description = c.String(),
                        City = c.String(),
                        Street = c.String(),
                        Postal = c.String(),
                        Longitude = c.Double(),
                        Latitude = c.Double(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.InfosSpecialities",
                c => new
                    {
                        SpecialityId = c.Int(nullable: false),
                        InfosId = c.String(nullable: false, maxLength: 128),
                        DateObtention = c.DateTime(nullable: false),
                        Infos_UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.SpecialityId, t.InfosId })
                .ForeignKey("dbo.Infos", t => t.Infos_UserId)
                .ForeignKey("dbo.Specialities", t => t.SpecialityId, cascadeDelete: true)
                .Index(t => t.SpecialityId)
                .Index(t => t.Infos_UserId);
            
            CreateTable(
                "dbo.Specialities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Label = c.String(),
                        ImgPath = c.String(),
                        Description = c.String(),
                        Special = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserMetadatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        file = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.MedicalRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateCreation = c.DateTime(nullable: false),
                        Description = c.String(nullable: false),
                        Badge_Id = c.Int(),
                        Speciality_Id = c.Int(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Badges", t => t.Badge_Id)
                .ForeignKey("dbo.Specialities", t => t.Speciality_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.Badge_Id)
                .Index(t => t.Speciality_Id)
                .Index(t => t.User_Id);
            
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
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.UserBadges",
                c => new
                    {
                        BadgeId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        DateObtention = c.DateTime(nullable: false),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.BadgeId, t.UserId })
                .ForeignKey("dbo.Badges", t => t.BadgeId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.BadgeId)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserBadges", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserBadges", "BadgeId", "dbo.Badges");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.MedicalRecords", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.MedicalRecords", "Speciality_Id", "dbo.Specialities");
            DropForeignKey("dbo.MedicalRecords", "Badge_Id", "dbo.Badges");
            DropForeignKey("dbo.UserMetadatas", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.InfosSpecialities", "SpecialityId", "dbo.Specialities");
            DropForeignKey("dbo.InfosSpecialities", "Infos_UserId", "dbo.Infos");
            DropForeignKey("dbo.Infos", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.FeedBacks", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Factures", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Factures", "FormularId", "dbo.Formulars");
            DropForeignKey("dbo.Consultations", "Doctor_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Consultations", "Client_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Comments", "Forum_ForumId", "dbo.Fora");
            DropForeignKey("dbo.Fora", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.UserBadges", new[] { "User_Id" });
            DropIndex("dbo.UserBadges", new[] { "BadgeId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.MedicalRecords", new[] { "User_Id" });
            DropIndex("dbo.MedicalRecords", new[] { "Speciality_Id" });
            DropIndex("dbo.MedicalRecords", new[] { "Badge_Id" });
            DropIndex("dbo.UserMetadatas", new[] { "User_Id" });
            DropIndex("dbo.InfosSpecialities", new[] { "Infos_UserId" });
            DropIndex("dbo.InfosSpecialities", new[] { "SpecialityId" });
            DropIndex("dbo.Infos", new[] { "User_Id" });
            DropIndex("dbo.FeedBacks", new[] { "User_Id" });
            DropIndex("dbo.Factures", new[] { "User_Id" });
            DropIndex("dbo.Factures", new[] { "FormularId" });
            DropIndex("dbo.Consultations", new[] { "Doctor_Id" });
            DropIndex("dbo.Consultations", new[] { "Client_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Fora", new[] { "User_Id" });
            DropIndex("dbo.Comments", new[] { "User_Id" });
            DropIndex("dbo.Comments", new[] { "Forum_ForumId" });
            DropTable("dbo.Services");
            DropTable("dbo.UserBadges");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.News");
            DropTable("dbo.MedicalRecords");
            DropTable("dbo.UserMetadatas");
            DropTable("dbo.Specialities");
            DropTable("dbo.InfosSpecialities");
            DropTable("dbo.Infos");
            DropTable("dbo.FeedBacks");
            DropTable("dbo.Formulars");
            DropTable("dbo.Factures");
            DropTable("dbo.Consultations");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Fora");
            DropTable("dbo.Comments");
            DropTable("dbo.Badges");
        }
    }
}
