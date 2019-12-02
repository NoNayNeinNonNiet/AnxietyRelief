namespace Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableCOL : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CrossOutLists",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Filtering = c.Boolean(nullable: false),
                        Overgeneralization = c.Boolean(nullable: false),
                        PolarizedThinking = c.Boolean(nullable: false),
                        Catastrophising = c.Boolean(nullable: false),
                        Shoulds = c.Boolean(nullable: false),
                        MindReading = c.Boolean(nullable: false),
                        EmotionalReasoning = c.Boolean(nullable: false),
                        Personalizing = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CrossOutLists", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.CrossOutLists", new[] { "UserId" });
            DropTable("dbo.CrossOutLists");
        }
    }
}
