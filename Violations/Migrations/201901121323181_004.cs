namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _004 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AllowedViolations", "PlainId", "dbo.Plains");
            DropIndex("dbo.AllowedViolations", new[] { "PlainId" });
            AlterColumn("dbo.AllowedViolations", "PlainId", c => c.Int());
            CreateIndex("dbo.AllowedViolations", "PlainId");
            AddForeignKey("dbo.AllowedViolations", "PlainId", "dbo.Plains", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AllowedViolations", "PlainId", "dbo.Plains");
            DropIndex("dbo.AllowedViolations", new[] { "PlainId" });
            AlterColumn("dbo.AllowedViolations", "PlainId", c => c.Int(nullable: false));
            CreateIndex("dbo.AllowedViolations", "PlainId");
            AddForeignKey("dbo.AllowedViolations", "PlainId", "dbo.Plains", "ID", cascadeDelete: true);
        }
    }
}
