namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Apple',95,0.5,0,0)");
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Banana',105,1.3,0,0)");
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Cheeseburger',300,15,14,30)");
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Pizza Slice',272,10,10,25)");
        }
        
        public override void Down()
        {
        }
    }
}
