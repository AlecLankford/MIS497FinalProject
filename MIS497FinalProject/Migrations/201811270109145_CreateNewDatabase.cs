namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateNewDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(),
                        Calories = c.Double(nullable: false),
                        Protein = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Carbs = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Healths",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BMI = c.Double(nullable: false),
                        WeightChange = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LogDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Birthdate = c.String(),
                        Weight = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Logs");
            DropTable("dbo.Healths");
            DropTable("dbo.Foods");
        }
    }
}
