namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migNews : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        TimeOfCreation = c.DateTime(),
                        TimeOfModification = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Newscast",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NewsTitle = c.String(),
                        NewsContent = c.String(),
                        NewsImage = c.String(),
                        CategoryId = c.Int(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        TimeOfCreation = c.DateTime(),
                        TimeOfModification = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Newscast", "CategoryId", "dbo.Category");
            DropIndex("dbo.Newscast", new[] { "CategoryId" });
            DropTable("dbo.Newscast");
            DropTable("dbo.Category");
        }
    }
}
