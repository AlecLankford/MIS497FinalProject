namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDB2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Foods", "FoodName", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Foods", "FoodName", c => c.String());
        }
    }
}
