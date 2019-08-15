namespace BoomUI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialDBSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BoomGears",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Boom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Booms", t => t.Boom_Id)
                .Index(t => t.Boom_Id);
            
            CreateTable(
                "dbo.Booms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        Name = c.String(),
                        Location_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .Index(t => t.Location_Id);
            
            CreateTable(
                "dbo.BoomSticks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Consumed = c.Boolean(nullable: false),
                        Species = c.String(),
                        Boom_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Booms", t => t.Boom_Id)
                .Index(t => t.Boom_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Species = c.String(),
                        Volume = c.Double(nullable: false),
                        Consumed = c.Boolean(nullable: false),
                        BoomId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Booms", t => t.BoomId, cascadeDelete: true)
                .Index(t => t.BoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Logs", "BoomId", "dbo.Booms");
            DropForeignKey("dbo.Booms", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.BoomSticks", "Boom_Id", "dbo.Booms");
            DropForeignKey("dbo.BoomGears", "Boom_Id", "dbo.Booms");
            DropIndex("dbo.Logs", new[] { "BoomId" });
            DropIndex("dbo.BoomSticks", new[] { "Boom_Id" });
            DropIndex("dbo.Booms", new[] { "Location_Id" });
            DropIndex("dbo.BoomGears", new[] { "Boom_Id" });
            DropTable("dbo.Logs");
            DropTable("dbo.Locations");
            DropTable("dbo.BoomSticks");
            DropTable("dbo.Booms");
            DropTable("dbo.BoomGears");
        }
    }
}
