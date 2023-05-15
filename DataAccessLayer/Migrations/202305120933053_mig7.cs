namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogRatng", c => c.Int(nullable: false));
            DropColumn("dbo.Blogs", "BlogRating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Blogs", "BlogRating", c => c.Int(nullable: false));
            DropColumn("dbo.Blogs", "BlogRatng");
        }
    }
}
