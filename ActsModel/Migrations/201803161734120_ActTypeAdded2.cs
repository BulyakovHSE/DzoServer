namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActTypeAdded2 : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.ActBases", "ActType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.ActBases", "ActType", c => c.Int());
        }
    }
}
