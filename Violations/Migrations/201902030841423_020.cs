namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _020 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.NotAllowedViolations", "StudyAreaId", c => c.Int());
            AddColumn("dbo.NotAllowedViolations", "CityId", c => c.Int());
            CreateIndex("dbo.NotAllowedViolations", "StudyAreaId");
            CreateIndex("dbo.NotAllowedViolations", "CityId");
            AddForeignKey("dbo.NotAllowedViolations", "CityId", "dbo.Cities", "ID");
            AddForeignKey("dbo.NotAllowedViolations", "StudyAreaId", "dbo.AreaStudies", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.NotAllowedViolations", "StudyAreaId", "dbo.AreaStudies");
            DropForeignKey("dbo.NotAllowedViolations", "CityId", "dbo.Cities");
            DropIndex("dbo.NotAllowedViolations", new[] { "CityId" });
            DropIndex("dbo.NotAllowedViolations", new[] { "StudyAreaId" });
            DropColumn("dbo.NotAllowedViolations", "CityId");
            DropColumn("dbo.NotAllowedViolations", "StudyAreaId");
        }
    }
}
