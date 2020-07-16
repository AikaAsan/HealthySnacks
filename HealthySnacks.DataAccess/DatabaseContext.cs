using HealthySnacks.DataAccess.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.IO;


namespace HealthySnacks.DataAccess
{
    public class DatabaseContext : DbContext
    {
        private const string DATABASE_PATH = "../HealthySnacks/SQLite/HealthySnacks.sqlite3";

    }
    public DatabaseContext() :
            base(new SQLiteConnection()
            {
                ConnectionString = new SQLiteConnectionStringBuilder()
                {
                    DataSource = DATABASE_PATH,
                    ForeignKeys = true
                }.ConnectionString
            }, true)


    {
        if (!file.Exists(DATABASE_PATH))

        {
            SQLiteConnection.CreateFile(DATABASE_PATH);
        }
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        base.OnModelCreating(modelBuilder);
    }
    
}
