namespace DlrModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class model1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ActBases", "DateCreationUl", c => c.DateTime());
            AddColumn("dbo.ActBases", "TimeCreationUl", c => c.DateTime());
            DropColumn("dbo.ActBases", "DateTimeCreation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActBases", "DateTimeCreation", c => c.DateTime());
            DropColumn("dbo.ActBases", "TimeCreationUl");
            DropColumn("dbo.ActBases", "DateCreationUl");
        }
    }
}
