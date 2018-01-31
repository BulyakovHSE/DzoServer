namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nullabledatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Acts", "CreationDate", c => c.DateTime());
            AlterColumn("dbo.Acts", "MakingStartTime", c => c.DateTime());
            AlterColumn("dbo.Acts", "MakingEndTime", c => c.DateTime());
            AlterColumn("dbo.Acts", "MakingLength", c => c.Time(precision: 7));
            AlterColumn("dbo.Acts", "ReasonDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Acts", "ReasonDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Acts", "MakingLength", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Acts", "MakingEndTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Acts", "MakingStartTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Acts", "CreationDate", c => c.DateTime(nullable: false));
        }
    }
}
