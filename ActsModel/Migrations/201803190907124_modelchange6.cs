namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchange6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActBases", "OrderDate", c => c.DateTime());
            AddColumn("dbo.ActBases", "OrderCreatorMakerInfo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActBases", "OrderCreatorMakerInfo");
            DropColumn("dbo.ActBases", "OrderDate");
        }
    }
}
