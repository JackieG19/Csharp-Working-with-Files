using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            
            // var files = Directory.GetFile(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);            
            // foreach(var file in files)
                // Console.WriteLine(file);
            
            // Returns the names of subdirectories that meet specified criteria.
            var directories = Directory.GetDirectories("c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            
            foreach(var directory in directories)
                Console.WriteLine(directory);
            
            /*Determines whether the given path refers to an existing directory on disk.*/
            Directory.Exists("..."); 
        }
    }
}
