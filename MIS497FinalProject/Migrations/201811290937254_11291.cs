namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _11291 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.UserFoods");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserFoods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        userID = c.Int(nullable: false),
                        FoodName = c.String(nullable: false, maxLength: 100),
                        Calories = c.Double(nullable: false),
                        Protein = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Carbs = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
