namespace ProjectManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_datecreated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "DateCreated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Members", "FirstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "FirstName", c => c.String());
            DropColumn("dbo.Members", "DateCreated");
        }
    }
}
