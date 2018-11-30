namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class selectfood : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodDTOes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        Calories = c.Double(nullable: false),
                        Protein = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Carbs = c.Double(nullable: false),
                        Selected = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FoodDTOes");
        }
    }
}
