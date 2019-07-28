namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migNews1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        TimeOfCreation = c.DateTime(),
                        TimeOfModification = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
