namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Acts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActNumber = c.Int(nullable: false),
                        TerritorialBodyName = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        MakingStartTime = c.DateTime(nullable: false),
                        MakingEndTime = c.DateTime(nullable: false),
                        MakingLength = c.Time(nullable: false, precision: 7),
                        MakingPlace = c.String(),
                        ReasonRequisites = c.String(),
                        ReasonDate = c.DateTime(nullable: false),
                        AreaAdress = c.String(),
                        AreaNumber = c.Int(nullable: false),
                        CadastrNumber = c.String(),
                        AreaSquare = c.Double(nullable: false),
                        MeasurementDeviceParams = c.String(),
                        CheckClass = c.Int(nullable: false),
                        CheckType = c.Int(nullable: false),
                        ActType = c.Int(nullable: false),
                        CreatorRegion = c.Int(nullable: false),
                        DocumentBytes = c.Binary(),
                        CheckContactInfo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactInfoes", t => t.CheckContactInfo_Id)
                .Index(t => t.CheckContactInfo_Id);
            
            CreateTable(
                "dbo.ContactInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fio = c.String(nullable: false),
                        Inn = c.Long(nullable: false),
                        Position = c.String(),
                        PhoneNumber = c.String(),
                        PassportNumber = c.Long(nullable: false),
                        PassportData = c.String(),
                        Act_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Acts", t => t.Act_Id)
                .Index(t => t.Act_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ContactInfoes", "Act_Id", "dbo.Acts");
            DropForeignKey("dbo.Acts", "CheckContactInfo_Id", "dbo.ContactInfoes");
            DropIndex("dbo.ContactInfoes", new[] { "Act_Id" });
            DropIndex("dbo.Acts", new[] { "CheckContactInfo_Id" });
            DropTable("dbo.ContactInfoes");
            DropTable("dbo.Acts");
        }
    }
}
