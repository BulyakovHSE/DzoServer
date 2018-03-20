using DlrModel.Model;

namespace DlrModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DzoContext : DbContext
    {
        // Your context has been configured to use a 'DzoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DlrModel.DzoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DzoContext' 
        // connection string in the application configuration file.
        public DzoContext()
            : base("name=DzoContextAzure")
        {
            if (Users.Count(x => x.Login == "admin") != 0) return;
            Users.Add(new User { Login = "admin", Password = "admin", Region = Region.All });
            SaveChanges();
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }

        public DbSet<ActBase> Acts { get; set; }

        public DbSet<ActCommon> CommonActs { get; set; }

        public DbSet<ActIndividual> IndividualActs { get; set; }

        public DbSet<ActInpectationFl> ActsInspectionFl { get; set; }

        public DbSet<ActInspectationUlIp> ActsInspectionUlIp { get; set; }

        public DbSet<ActInspection> ActsInspection { get; set; }

        public DbSet<AgreementStatement> AgreementStatements { get; set; }

        public DbSet<AreaMeasurement> AreaMeasurements { get; set; }

        public DbSet<CheckingJournal> CheckingJournals { get; set; }

        public DbSet<CitizensCheckPlan> CitizensCheckPlans { get; set; }

        public DbSet<OrderInspectionUlIp> OrderInspectionsUlIp { get; set; }

        public DbSet<PhotoTable> PhotoTables { get; set; }

        public DbSet<Protocol> Protocols { get; set; }

        public DbSet<Regulation> Regulations { get; set; }

        public DbSet<User> Users { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}