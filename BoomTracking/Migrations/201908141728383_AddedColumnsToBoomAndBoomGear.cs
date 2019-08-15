namespace BoomTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedColumnsToBoomAndBoomGear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BoomGears", "Description", c => c.String());
            AddColumn("dbo.Booms", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Booms", "IsActive");
            DropColumn("dbo.BoomGears", "Description");
        }
    }
}
