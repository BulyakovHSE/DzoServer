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
        }

        public DbSet<Act> Acts { get; set; }
    }
}