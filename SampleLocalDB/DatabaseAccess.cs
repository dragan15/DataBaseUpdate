//In this class, create a SQLite Connection and Query the database table to return rows from the table.Use the returned rows to bind to your xaml list views.

using System;
using SQLite.Net;
using System.Collections.Generic;
using Xamarin.Forms;

namespace DineNDash
{
    public class DatabaseAccess
    {
        SQLiteConnection dbConnection;
        public DatabaseManager()
        {
            dbConnection = DependencyService.Get<IDBInterface>().CreateConnection();
        }

        public List<Restaraunt_tableDatabase> GetAllRestaraunts()
        {
            return dbConnection.Query<Restaraunt_tableDatabase>("Select * From [Restaraunt]");
        }
    }
}
