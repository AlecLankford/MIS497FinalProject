namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "lastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "lastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
