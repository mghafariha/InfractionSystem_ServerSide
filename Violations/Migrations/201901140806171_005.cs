namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _005 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NotAllowedViolations", "CityId", "dbo.Cities");
            DropForeignKey("dbo.NotAllowedViolations", "StudyAreaId", "dbo.AreaStudies");
            DropForeignKey("dbo.NotAllowedViolations", "PlainId", "dbo.Plains");
            DropIndex("dbo.NotAllowedViolations", new[] { "StudyAreaId" });
            DropIndex("dbo.NotAllowedViolations", new[] { "PlainId" });
            DropIndex("dbo.NotAllowedViolations", new[] { "CityId" });
            AlterColumn("dbo.NotAllowedViolations", "PlainId", c => c.Int());
            CreateIndex("dbo.NotAllowedViolations", "PlainId");
            AddForeignKey("dbo.NotAllowedViolations", "PlainId", "dbo.Plains", "ID");
            DropColumn("dbo.NotAllowedViolations", "StudyAreaId");
            DropColumn("dbo.NotAllowedViolations", "CityId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NotAllowedViolations", "CityId", c => c.Int(nullable: false));
            AddColumn("dbo.NotAllowedViolations", "StudyAreaId", c => c.Int(nullable: false));
            DropForeignKey("dbo.NotAllowedViolations", "PlainId", "dbo.Plains");
            DropIndex("dbo.NotAllowedViolations", new[] { "PlainId" });
            AlterColumn("dbo.NotAllowedViolations", "PlainId", c => c.Int(nullable: false));
            CreateIndex("dbo.NotAllowedViolations", "CityId");
            CreateIndex("dbo.NotAllowedViolations", "PlainId");
            CreateIndex("dbo.NotAllowedViolations", "StudyAreaId");
            AddForeignKey("dbo.NotAllowedViolations", "PlainId", "dbo.Plains", "ID", cascadeDelete: true);
            AddForeignKey("dbo.NotAllowedViolations", "StudyAreaId", "dbo.AreaStudies", "ID", cascadeDelete: true);
            AddForeignKey("dbo.NotAllowedViolations", "CityId", "dbo.Cities", "ID", cascadeDelete: true);
        }
    }
}
