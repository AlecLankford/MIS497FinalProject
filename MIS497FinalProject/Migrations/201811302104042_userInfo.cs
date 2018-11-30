namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userInfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Age", c => c.String());
            AddColumn("dbo.AspNetUsers", "Height", c => c.String());
            AddColumn("dbo.AspNetUsers", "Weight", c => c.String());
            AddColumn("dbo.AspNetUsers", "GoalWeight", c => c.String());
            AddColumn("dbo.AspNetUsers", "BMI", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BMI");
            DropColumn("dbo.AspNetUsers", "GoalWeight");
            DropColumn("dbo.AspNetUsers", "Weight");
            DropColumn("dbo.AspNetUsers", "Height");
            DropColumn("dbo.AspNetUsers", "Age");
        }
    }
}
