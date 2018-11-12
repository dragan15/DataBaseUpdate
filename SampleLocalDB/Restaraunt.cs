//Class that defines the database that we created. Each Class Represents a respective table

using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SampleLocalDB
{       /*RESTARAUNT_TABLE*/
    public class Restaraunt_table
    {
        [PrimaryKey, AutoIncrement]
        public int Restaraunt_ID
        {
            get;
            set;
        }
        public string Restaraunt_Name
        {
            get;
            set;
        }
        public string Restaraunt_Address
        {
            get;
            set;
        }
        public string Restaraunt_City
        {
            get;
            set;
        }
        public int Restaraunt_State
        {
            get;
            set;
        }
        public int Restaraunt_Zip
        {
            get;
            set;
        }
        public string Restaraunt_Phone
        {
            get;
            set;
        }
        public String Restaraunt_Email
        {
            get;
            set;
        }
        public float Restaraunt_Lat
        {
            get;
            set;
        }
        public float Restaraunt_Long
        {
            get;
            set;
        }

        [ForeignKey(typeof(Restaraunt_Menu))]
        public int Menu_ID
        {
            get;
            set;

        }
    }
    /*  RESTARAUNT_MENU TABLE*/
    public class Restaraunt_Menu
    {
        [PrimaryKey, AutoIncrement]
        public int Menu_ID
        {
            get;
            set;
        }
        public string Menu_Name
        {
            get;
            set;
        }
        [ForeignKey(typeof(Menu_Category))]
        public int Category_ID
        {
            get;
            set;
        }
        public string Menu_Description
        {
            get;
            set;
        }
        public string Menu_Image
        {
            get;
            set;
        }
    }
    /*  MENU_CATEGORY Table */
    public class Menu_Category
    {
        [PrimaryKey, AutoIncrement]
        public int Category_ID
        {
            get;
            set;
        }
        public string Category_Name
        {
            get;
            set;
        }
        public string Category_Description
        {
            get;
            set;
        }
        public float Category_Price
        {
            get;
            set;
        }
    }
}