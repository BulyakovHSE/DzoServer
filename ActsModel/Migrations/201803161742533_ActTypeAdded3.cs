namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActTypeAdded3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ActBases", "ActType");
            AddColumn("dbo.ActBases", "ActType", c => c.Int(false));
        }
        
        public override void Down()
        {
        }
    }
}
