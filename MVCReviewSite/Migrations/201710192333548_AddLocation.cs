namespace MVCReviewSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reviews", "Location");
        }
    }
}
