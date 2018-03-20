namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ActTypeAdded1 : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.ActBases", "ActType", c => c.Int(nullable: false));
            DropColumn("dbo.ActBases", "ActType1");
            DropColumn("dbo.ActBases", "ActType2");
            DropColumn("dbo.ActBases", "ActType3");
            DropColumn("dbo.ActBases", "ActType4");
            DropColumn("dbo.ActBases", "ActType5");
            DropColumn("dbo.ActBases", "ActType6");
            DropColumn("dbo.ActBases", "ActType7");
            DropColumn("dbo.ActBases", "ActType8");
            DropColumn("dbo.ActBases", "ActType9");
            DropColumn("dbo.ActBases", "ActType10");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActBases", "ActType10", c => c.Int());
            AddColumn("dbo.ActBases", "ActType9", c => c.Int());
            AddColumn("dbo.ActBases", "ActType8", c => c.Int());
            AddColumn("dbo.ActBases", "ActType7", c => c.Int());
            AddColumn("dbo.ActBases", "ActType6", c => c.Int());
            AddColumn("dbo.ActBases", "ActType5", c => c.Int());
            AddColumn("dbo.ActBases", "ActType4", c => c.Int());
            AddColumn("dbo.ActBases", "ActType3", c => c.Int());
            AddColumn("dbo.ActBases", "ActType2", c => c.Int());
            AddColumn("dbo.ActBases", "ActType1", c => c.Int());
            //AlterColumn("dbo.ActBases", "ActType", c => c.Int());
        }
    }
}
