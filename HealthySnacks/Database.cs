using System;
using System.Data.SQLite;
using System.IO;



namespace HealthySnacks
{
    public class Database
    {
        public SQLiteConnection sqliteConnection;

        public Database()
        {
            sqliteConnection = new SQLiteConnection("Data Source=database.sqlite3"); 

            if (!File.Exists("./database.sqlite3"))
            {
                SQLiteConnection.CreateFile("database.sqlite3");
            }
        }
    }
}
