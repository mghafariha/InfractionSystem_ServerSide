namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AllowedViolations", "WellDepth", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AllowedViolations", "WellDepth");
        }
    }
}
