namespace ActsModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modelchange4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ActBases", "DateTimeCreation");
            DropColumn("dbo.ActBases", "CheckType2");
            RenameColumn(table: "dbo.ActBases", name: "DateTimeCreation1", newName: "DateTimeCreation");
            RenameColumn(table: "dbo.ActBases", name: "CheckType3", newName: "CheckType2");
            AddColumn("dbo.ActBases", "DateOfCreation", c => c.DateTime());
            AddColumn("dbo.ActBases", "TimeOfCreation", c => c.DateTime());
            AddColumn("dbo.ActBases", "CheckDateStartAndFinishNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CommonCheckDurationNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "StateControlNameNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "DateNumOrOrderOfCheckNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckAimTaskAndObjectNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckTypeNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "DateNumOfCheckResNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "FoundViolationsNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "DateNumOfContentOfEliminationNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckerPersonInfoNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "ExpertsInfoNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "ApprovedDate", c => c.DateTime());
            AddColumn("dbo.ActBases", "EarthObjectNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CitizenNameNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckAimNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckBaseNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckStartDateNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckDurationInDaysNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "FederalBodyNameNoUnderline", c => c.String());
            AddColumn("dbo.ActBases", "CheckingDateStart", c => c.DateTime());
            AddColumn("dbo.ActBases", "CheckingDateFinish", c => c.DateTime());
            AddColumn("dbo.ActBases", "Time", c => c.DateTime());
            DropColumn("dbo.ActBases", "CheckDateStartAndFinish");
            DropColumn("dbo.ActBases", "CommonCheckDuration1");
            DropColumn("dbo.ActBases", "StateControlName");
            DropColumn("dbo.ActBases", "DateNumOrOrderOfCheck");
            DropColumn("dbo.ActBases", "CheckAimTaskAndObject");
            DropColumn("dbo.ActBases", "DateNumOfCheckRes");
            DropColumn("dbo.ActBases", "FoundViolations");
            DropColumn("dbo.ActBases", "DateNumOfContentOfElimination");
            DropColumn("dbo.ActBases", "CheckerPersonInfo");
            DropColumn("dbo.ActBases", "ApprovedTime");
            DropColumn("dbo.ActBases", "EarthObject");
            DropColumn("dbo.ActBases", "CitizenName");
            DropColumn("dbo.ActBases", "CheckAim");
            DropColumn("dbo.ActBases", "CheckBase1");
            DropColumn("dbo.ActBases", "CheckStartDate");
            DropColumn("dbo.ActBases", "CheckDurationInDays");
            DropColumn("dbo.ActBases", "FederalBodyName");
            DropColumn("dbo.ActBases", "CheckingTimeStart");
            DropColumn("dbo.ActBases", "CheckingTimeFinish");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ActBases", "CheckingTimeFinish", c => c.DateTime());
            AddColumn("dbo.ActBases", "CheckingTimeStart", c => c.DateTime());
            AddColumn("dbo.ActBases", "FederalBodyName", c => c.String());
            AddColumn("dbo.ActBases", "CheckDurationInDays", c => c.String());
            AddColumn("dbo.ActBases", "CheckStartDate", c => c.String());
            AddColumn("dbo.ActBases", "CheckBase1", c => c.String());
            AddColumn("dbo.ActBases", "CheckAim", c => c.String());
            AddColumn("dbo.ActBases", "CitizenName", c => c.String());
            AddColumn("dbo.ActBases", "EarthObject", c => c.String());
            AddColumn("dbo.ActBases", "ApprovedTime", c => c.DateTime());
            AddColumn("dbo.ActBases", "CheckerPersonInfo", c => c.String());
            AddColumn("dbo.ActBases", "DateNumOfContentOfElimination", c => c.String());
            AddColumn("dbo.ActBases", "FoundViolations", c => c.String());
            AddColumn("dbo.ActBases", "DateNumOfCheckRes", c => c.String());
            AddColumn("dbo.ActBases", "CheckAimTaskAndObject", c => c.String());
            AddColumn("dbo.ActBases", "DateNumOrOrderOfCheck", c => c.String());
            AddColumn("dbo.ActBases", "StateControlName", c => c.String());
            AddColumn("dbo.ActBases", "CommonCheckDuration1", c => c.String());
            AddColumn("dbo.ActBases", "CheckDateStartAndFinish", c => c.String());
            DropColumn("dbo.ActBases", "Time");
            DropColumn("dbo.ActBases", "CheckingDateFinish");
            DropColumn("dbo.ActBases", "CheckingDateStart");
            DropColumn("dbo.ActBases", "FederalBodyNameNoUnderline");
            DropColumn("dbo.ActBases", "CheckDurationInDaysNoUnderline");
            DropColumn("dbo.ActBases", "CheckStartDateNoUnderline");
            DropColumn("dbo.ActBases", "CheckBaseNoUnderline");
            DropColumn("dbo.ActBases", "CheckAimNoUnderline");
            DropColumn("dbo.ActBases", "CitizenNameNoUnderline");
            DropColumn("dbo.ActBases", "EarthObjectNoUnderline");
            DropColumn("dbo.ActBases", "ApprovedDate");
            DropColumn("dbo.ActBases", "ExpertsInfoNoUnderline");
            DropColumn("dbo.ActBases", "CheckerPersonInfoNoUnderline");
            DropColumn("dbo.ActBases", "DateNumOfContentOfEliminationNoUnderline");
            DropColumn("dbo.ActBases", "FoundViolationsNoUnderline");
            DropColumn("dbo.ActBases", "DateNumOfCheckResNoUnderline");
            DropColumn("dbo.ActBases", "CheckTypeNoUnderline");
            DropColumn("dbo.ActBases", "CheckAimTaskAndObjectNoUnderline");
            DropColumn("dbo.ActBases", "DateNumOrOrderOfCheckNoUnderline");
            DropColumn("dbo.ActBases", "StateControlNameNoUnderline");
            DropColumn("dbo.ActBases", "CommonCheckDurationNoUnderline");
            DropColumn("dbo.ActBases", "CheckDateStartAndFinishNoUnderline");
            DropColumn("dbo.ActBases", "TimeOfCreation");
            DropColumn("dbo.ActBases", "DateOfCreation");
            RenameColumn(table: "dbo.ActBases", name: "CheckType2", newName: "CheckType3");
            RenameColumn(table: "dbo.ActBases", name: "DateTimeCreation", newName: "DateTimeCreation1");
            AddColumn("dbo.ActBases", "CheckType2", c => c.String());
            AddColumn("dbo.ActBases", "DateTimeCreation", c => c.DateTime());
        }
    }
}
