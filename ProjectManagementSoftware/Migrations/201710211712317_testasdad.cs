namespace ProjectManagementSoftware.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testasdad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "PasswordHash", c => c.String());
            DropColumn("dbo.Members", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Password", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.Members", "PasswordHash");
        }
    }
}
