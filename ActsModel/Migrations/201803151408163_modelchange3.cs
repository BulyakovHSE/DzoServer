namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchange3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ActBases", "JournalStartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ActBases", "JournalStartDate", c => c.String());
        }
    }
}
