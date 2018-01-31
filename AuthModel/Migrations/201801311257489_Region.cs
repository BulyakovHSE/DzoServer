namespace AuthModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Region : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Region", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Permission");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Permission", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "Region");
        }
    }
}
