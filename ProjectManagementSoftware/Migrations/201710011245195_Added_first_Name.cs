namespace ProjectManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_first_Name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "FirstName", c => c.String());
            AlterColumn("dbo.Members", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Members", "Password", c => c.String(nullable: false, maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Members", "Password", c => c.String());
            AlterColumn("dbo.Members", "Email", c => c.String());
            DropColumn("dbo.Members", "FirstName");
        }
    }
}
