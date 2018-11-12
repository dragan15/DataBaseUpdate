//Interface that fetches from local path to applications, and perforns all applications
//THIS IS WHERE WE WRITE QUERY COMMANDS TO MANIPULATE DATA IN RESTARAUNT_MENU TABLE
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using SQLite;
namespace SampleLocalDB
{
    public class Restaraunt_MenuDatabase
    {
        //create a connection for SQLite
        readonly SQLiteAsyncConnection database;

        public Restaraunt_MenuDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Restaraunt_Menu>().Wait(); //FETCHES FROM REATARAYBT_MENU TABLE
        }
        //START OF QUERY COMMANDS
        //Get all restaraunt menus
        public Task<List<Restaraunt_Menu>>GetRestarauntAsync()
        {
            return database.Table<Restaraunt_Menu>().ToListAsync();
        }
    }

}
