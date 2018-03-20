namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchange5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActBases", "CreatorInfoFirstName", c => c.String());
            AddColumn("dbo.ActBases", "ViolationAuthor2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ActBases", "ViolationAuthor2");
            DropColumn("dbo.ActBases", "CreatorInfoFirstName");
        }
    }
}
