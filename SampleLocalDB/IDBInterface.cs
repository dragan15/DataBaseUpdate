//Database Interface. Provides onnection to database. Used for the purpose of manipulating data to the database

using System;
using SQLite;
namespace SampleLocalDB
{
    public interface IDBInterface
    {
        SQLiteConnection CreateConnection();
        
    }
}
