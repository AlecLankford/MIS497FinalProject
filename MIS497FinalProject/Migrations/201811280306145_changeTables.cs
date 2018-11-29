namespace MIS497FinalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTables : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Healths");
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
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
            
            CreateTable(
                "dbo.Healths",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BMI = c.Double(nullable: false),
                        WeightChange = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
