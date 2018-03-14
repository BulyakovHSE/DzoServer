using ActsModel.Model;

namespace ActsModel
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DzoContext : DbContext
    {
        // Your context has been configured to use a 'DzoContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ActsModel.DzoContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DzoContext' 
        // connection string in the application configuration file.
        public DzoContext()
            : base("name=DzoContext")
        {
            if (Users.Count(x => x.Login == "admin") != 0) return;
            Users.Add(new User {Login = "admin", Password = "admin", Region = Region.All});
            SaveChanges();
        }

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

        //public DbSet<Act> Acts { get; set; }

        public DbSet<User> Users { get; set; }
    }
}