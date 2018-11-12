using System;
using System.IO;
using SampleLocalDB.iOS;
using Xamarin.Forms;

[assembly :Dependency(typeof(LocalFileHelper))]
namespace SampleLocalDB.iOS
{
    public class LocalFileHelper : ILocalFileHelper
    {
        public string GetLocalFilePath(string fileName)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //Complete path for database that is stored in this device
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");
            //if database doesnt exist, create a new file with new directory 
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
             
            return Path.Combine (libFolder, fileName);
        }
    }
}
