namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _003 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AllowedViolations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.AllowedViolations", "StudyAreaId", "dbo.AreaStudies");
            DropIndex("dbo.AllowedViolations", new[] { "StudyAreaId" });
            DropIndex("dbo.AllowedViolations", new[] { "CityId" });
            DropColumn("dbo.AllowedViolations", "StudyAreaId");
            DropColumn("dbo.AllowedViolations", "CityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AllowedViolations", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.AllowedViolations", "StudyAreaId", c => c.Int(nullable: false));
            CreateIndex("dbo.AllowedViolations", "CityId");
            CreateIndex("dbo.AllowedViolations", "StudyAreaId");
            AddForeignKey("dbo.AllowedViolations", "StudyAreaId", "dbo.AreaStudies", "ID", cascadeDelete: true);
            AddForeignKey("dbo.AllowedViolations", "CityId", "dbo.Cities", "ID", cascadeDelete: true);
        }
    }
}
