namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addUserFoodTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserFoods",
                c => new
                {
                    userFoodID = c.Int(nullable: false, identity: true),
                    userId = c.Int(nullable: false),
                    FoodName = c.String(),
                    Calories = c.Double(nullable: false),
                    Protein = c.Double(nullable: true),
                    Fat = c.Double(nullable: true),
                    Carbs = c.Double(nullable: true),
                })
                .PrimaryKey(t => t.userFoodID);
        }
        
        public override void Down()
        {
        }
    }
}
