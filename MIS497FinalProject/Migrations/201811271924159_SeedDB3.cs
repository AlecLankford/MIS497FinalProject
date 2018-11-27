namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDB3 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Chicken Alfredo',475,30,15,96)");
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Soda',115,0,0,40)");
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Chicken Noodle Soup',87,6,3,8)");
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Bag of Chips',160,20,12,5)");
            Sql("INSERT INTO Foods (FoodName, Calories, Protein, Fat, Carbs) VALUES ('Chicken and Rice',577,19.5,14,95)");

        }
        
        public override void Down()
        {
        }
    }
}
