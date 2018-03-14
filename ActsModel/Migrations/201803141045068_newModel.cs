namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Acts", "CheckContactInfo_Id", "dbo.ContactInfoes");
            DropForeignKey("dbo.ContactInfoes", "Act_Id", "dbo.Acts");
            DropIndex("dbo.Acts", new[] { "CheckContactInfo_Id" });
            DropIndex("dbo.ContactInfoes", new[] { "Act_Id" });
            CreateTable(
                "dbo.ActBases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Region = c.Int(nullable: false),
                        DocumentBytes = c.Binary(),
                        CommonNum = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.Acts");
            DropTable("dbo.ContactInfoes");
        }
        
        public override void Down()
        {
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
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Acts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActNumber = c.Int(nullable: false),
                        TerritorialBodyName = c.String(),
                        CreationDate = c.DateTime(),
                        MakingStartTime = c.DateTime(),
                        MakingEndTime = c.DateTime(),
                        MakingLength = c.Time(precision: 7),
                        MakingPlace = c.String(),
                        ReasonRequisites = c.String(),
                        ReasonDate = c.DateTime(),
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
                .PrimaryKey(t => t.Id);
            
            DropTable("dbo.ActBases");
            CreateIndex("dbo.ContactInfoes", "Act_Id");
            CreateIndex("dbo.Acts", "CheckContactInfo_Id");
            AddForeignKey("dbo.ContactInfoes", "Act_Id", "dbo.Acts", "Id");
            AddForeignKey("dbo.Acts", "CheckContactInfo_Id", "dbo.ContactInfoes", "Id");
        }
    }
}
