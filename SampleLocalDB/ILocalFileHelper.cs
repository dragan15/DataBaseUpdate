//Interface that Specifies path to IOS and android applications

using System;
namespace SampleLocalDB
{
    public interface ILocalFileHelper
    {
        string GetLocalFilePath(string fileName); //takes the path of the local filenamw
        
    }
}
