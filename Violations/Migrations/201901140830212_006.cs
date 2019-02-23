namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _006 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AllowedViolations", "InfractionType", c => c.String());
            AddColumn("dbo.NotAllowedViolations", "InfractionType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.NotAllowedViolations", "InfractionType");
            DropColumn("dbo.AllowedViolations", "InfractionType");
        }
    }
}
