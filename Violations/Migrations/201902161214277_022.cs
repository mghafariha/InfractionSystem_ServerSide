namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _022 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AllowedViolations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.AllowedViolations", "StudyAreaId", "dbo.AreaStudies");
            DropForeignKey("dbo.NotAllowedViolations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.NotAllowedViolations", "StudyAreaId", "dbo.AreaStudies");
            DropIndex("dbo.AllowedViolations", new[] { "StudyAreaId" });
            DropIndex("dbo.AllowedViolations", new[] { "CityId" });
            DropIndex("dbo.NotAllowedViolations", new[] { "StudyAreaId" });
            DropIndex("dbo.NotAllowedViolations", new[] { "CityId" });
            DropColumn("dbo.AllowedViolations", "StudyAreaId");
            DropColumn("dbo.AllowedViolations", "CityId");
            DropColumn("dbo.NotAllowedViolations", "StudyAreaId");
            DropColumn("dbo.NotAllowedViolations", "CityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NotAllowedViolations", "CityId", c => c.Int());
            AddColumn("dbo.NotAllowedViolations", "StudyAreaId", c => c.Int());
            AddColumn("dbo.AllowedViolations", "CityId", c => c.Int());
            AddColumn("dbo.AllowedViolations", "StudyAreaId", c => c.Int());
            CreateIndex("dbo.NotAllowedViolations", "CityId");
            CreateIndex("dbo.NotAllowedViolations", "StudyAreaId");
            CreateIndex("dbo.AllowedViolations", "CityId");
            CreateIndex("dbo.AllowedViolations", "StudyAreaId");
            AddForeignKey("dbo.NotAllowedViolations", "StudyAreaId", "dbo.AreaStudies", "ID");
            AddForeignKey("dbo.NotAllowedViolations", "CityId", "dbo.Cities", "ID");
            AddForeignKey("dbo.AllowedViolations", "StudyAreaId", "dbo.AreaStudies", "ID");
            AddForeignKey("dbo.AllowedViolations", "CityId", "dbo.Cities", "ID");
        }
    }
}
