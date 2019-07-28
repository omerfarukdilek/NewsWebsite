namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migNews2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Category", "CategoryName", c => c.String(nullable: false));
            AlterColumn("dbo.Newscast", "NewsTitle", c => c.String(nullable: false));
            AlterColumn("dbo.Newscast", "NewsContent", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Newscast", "NewsContent", c => c.String());
            AlterColumn("dbo.Newscast", "NewsTitle", c => c.String());
            AlterColumn("dbo.Category", "CategoryName", c => c.String());
        }
    }
}
