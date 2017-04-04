namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "comments", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Gigs", "comments");
        }
    }
}
