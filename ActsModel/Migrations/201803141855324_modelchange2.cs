namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchange2 : DbMigration
    {
        public override void Up()
        {
            //DropColumn("dbo.ActBases", "Discriminator");
            //RenameColumn(table: "dbo.ActBases", name: "Discriminator1", newName: "Discriminator");
            AlterColumn("dbo.ActBases", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            //AlterColumn("dbo.ActBases", "Discriminator", c => c.String());
            //RenameColumn(table: "dbo.ActBases", name: "Discriminator", newName: "Discriminator1");
            //AddColumn("dbo.ActBases", "Discriminator", c => c.String());
        }
    }
}
