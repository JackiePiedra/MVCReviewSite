namespace MVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PlaceCategory = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        CustomerReview = c.String(nullable: false),
                        VisitDate = c.DateTime(nullable: false),
                        Recommend = c.Boolean(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Reviews", new[] { "CategoryID" });
            DropTable("dbo.Reviews");
            DropTable("dbo.Categories");
        }
    }
}
