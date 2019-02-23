namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllowedViolations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Index = c.String(),
                        StudyAreaId = c.Int(nullable: false),
                        PlainId = c.Int(nullable: false),
                        OwnerName = c.String(),
                        CityId = c.Int(nullable: false),
                        Village = c.String(),
                        Subscribe = c.String(),
                        LicenseNumber = c.String(),
                        LicenseDate = c.DateTime(nullable: false),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pipe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EnginePower = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeLicense = c.String(),
                        Cultivated = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CultivateType = c.String(),
                        Industry = c.String(),
                        Drinking = c.String(),
                        DebiMojaz = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ArtifactsType = c.String(),
                        DugMethod = c.String(),
                        TypeWell = c.String(),
                        Volume = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        CultivatedFalse = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CultivateTypeFalse = c.String(),
                        UseFalse = c.String(),
                        DebiPresent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VolumePresent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ChangeUse = c.String(),
                        UseTiny = c.String(),
                        Overdrawn = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeMeter = c.String(),
                        MeterCompany = c.String(),
                        DateInstallation = c.DateTime(nullable: false),
                        ChargeMeter = c.String(),
                        NumberMeter = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlaceMeter = c.String(),
                        OverdrawnPrv = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Saving = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PlumbMeter = c.String(),
                        PipeNew = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EnginePowerNew = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VolumeSaving = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransferLine = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FloorBreaker = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WaterSupply = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UserFalse = c.String(),
                        EndDate = c.DateTime(nullable: false),
                        LongitudeViolation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LatitudeViolation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VolumOfWell = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WasteWater = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VolumeFiltration = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Plains", t => t.PlainId, cascadeDelete: true)
                .ForeignKey("dbo.AreaStudies", t => t.StudyAreaId, cascadeDelete: true)
                .Index(t => t.StudyAreaId)
                .Index(t => t.PlainId)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        OmorExpert = c.Int(nullable: false),
                        AreaManager = c.Int(nullable: false),
                        LegalExpert = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Plains",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        City = c.Int(nullable: false),
                        AreaStudy = c.Int(nullable: false),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AreaStudies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Code = c.String(nullable: false),
                        Kind = c.String(nullable: false),
                        Pilot = c.String(nullable: false),
                        VisitExpert = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.NotAllowedViolations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Index = c.String(),
                        StudyAreaId = c.Int(nullable: false),
                        PlainId = c.Int(nullable: false),
                        OwnerName = c.String(),
                        CityId = c.Int(nullable: false),
                        Village = c.String(),
                        Longitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DugDate = c.DateTime(nullable: false),
                        WorkHours = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeUse = c.String(),
                        StartDateOperation = c.DateTime(nullable: false),
                        DebiMoment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VolumeSaved = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AquiferDamage = c.String(),
                        Description = c.String(),
                        SerialPlumb = c.String(),
                        years = c.String(),
                        UsePresent = c.Decimal(nullable: false, precision: 18, scale: 2),
                        WellDepthViolation = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeWellViolation = c.String(),
                        WellPosition = c.String(),
                        EngineType = c.String(),
                        DateFull = c.DateTime(nullable: false),
                        AnnualDischarge = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HistoryBlocked = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Plains", t => t.PlainId, cascadeDelete: true)
                .ForeignKey("dbo.AreaStudies", t => t.StudyAreaId, cascadeDelete: true)
                .Index(t => t.StudyAreaId)
                .Index(t => t.PlainId)
                .Index(t => t.CityId);
            
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
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Hometown = c.String(),
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
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.NotAllowedViolations", "StudyAreaId", "dbo.AreaStudies");
            DropForeignKey("dbo.NotAllowedViolations", "PlainId", "dbo.Plains");
            DropForeignKey("dbo.NotAllowedViolations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.AllowedViolations", "StudyAreaId", "dbo.AreaStudies");
            DropForeignKey("dbo.AllowedViolations", "PlainId", "dbo.Plains");
            DropForeignKey("dbo.AllowedViolations", "CityId", "dbo.Cities");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.NotAllowedViolations", new[] { "CityId" });
            DropIndex("dbo.NotAllowedViolations", new[] { "PlainId" });
            DropIndex("dbo.NotAllowedViolations", new[] { "StudyAreaId" });
            DropIndex("dbo.AllowedViolations", new[] { "CityId" });
            DropIndex("dbo.AllowedViolations", new[] { "PlainId" });
            DropIndex("dbo.AllowedViolations", new[] { "StudyAreaId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.NotAllowedViolations");
            DropTable("dbo.AreaStudies");
            DropTable("dbo.Plains");
            DropTable("dbo.Cities");
            DropTable("dbo.AllowedViolations");
        }
    }
}
