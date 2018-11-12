//Interface that fetches from local path to applications, and perforns all applications. 
//THIS IS WHERE WE WRITE QUERY COMMANDS TO MANIPULATE DATA IN MENU_CATEGORY TABLE

using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using SQLite;
namespace SampleLocalDB
{
    public class Menu_CategoryDatabase
    {
        //create a connection for SQLite
        readonly SQLiteAsyncConnection database;

        public Menu_CategoryDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Menu_Category>().Wait(); //FETCHES FROM MENU_category TABLE 
        }
        //START OF QUERY COMMANDS
        //Get all restaraunt menus
        public Task<List<Restaraunt_Menu>> GetRestarauntAsync()
        {
            return database.Table<Restaraunt_Menu>().ToListAsync();
        }
    }

}