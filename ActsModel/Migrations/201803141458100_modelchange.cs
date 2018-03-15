namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActBases", "RegionNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActBases", "RegionNum");
        }
    }
}
