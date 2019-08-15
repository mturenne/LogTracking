namespace BoomTracking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameColumnToBoomsTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Booms", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Booms", "Name");
        }
    }
}
