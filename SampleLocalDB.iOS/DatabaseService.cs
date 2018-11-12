using System;
using System.IO;
using SampleLocalDB.iOS;
using Foundation;
using SQLite;
using Xamarin.Forms;

[assembly: Dependency(typeof(DatabaseService))]
namespace SampleLocalDB.iOS
{
    public class DatabaseService : IDBInterface
    {

        public SQLite.Net.SQLiteConnection CreateConnection()
        {
            var sqliteFilename = "RestarauntDatabase.db";

            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = System.IO.Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            string path = Path.Combine(libFolder, sqliteFilename);

            // This is where we copy in the pre-created database
            if (!File.Exists(path))
            {
                var existingDb = NSBundle.MainBundle.PathForResource("Employee", "db");
                File.Copy(existingDb, path);
            }

            var iOSPlatform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            var connection = new SQLite.Net.SQLiteConnection(iOSPlatform, path);

            // Return the database connection 
            return connection;
        }

        SQLiteConnection IDBInterface.CreateConnection() => throw new NotImplementedException();
    }
}
