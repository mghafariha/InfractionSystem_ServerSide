namespace Violations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AllowedViolations", "LicenseDate", c => c.DateTime());
            AlterColumn("dbo.AllowedViolations", "DateInstallation", c => c.DateTime());
            AlterColumn("dbo.AllowedViolations", "EndDate", c => c.DateTime());
            AlterColumn("dbo.NotAllowedViolations", "DugDate", c => c.DateTime());
            AlterColumn("dbo.NotAllowedViolations", "StartDateOperation", c => c.DateTime());
            AlterColumn("dbo.NotAllowedViolations", "DateFull", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.NotAllowedViolations", "DateFull", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NotAllowedViolations", "StartDateOperation", c => c.DateTime(nullable: false));
            AlterColumn("dbo.NotAllowedViolations", "DugDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AllowedViolations", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AllowedViolations", "DateInstallation", c => c.DateTime(nullable: false));
            AlterColumn("dbo.AllowedViolations", "LicenseDate", c => c.DateTime(nullable: false));
        }
    }
}
