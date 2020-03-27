using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");
            
            var directories = Directory.GetDirectories("c:\projects\CSharpFundamentals", "*.*", SearchOption.AllDirectories);
            
            foreach(var directory in directories)
                Console.WriteLine(directory);
   
            Directory.Exists("..."); 
            
            /*DirectoryInfo - Exposes instance methods for creating, moving, and enumerating 
            through directories and subdirectories. This class cannot be inherited.*/
            
            var directoryInfo = new DirectoryInfo("...");
            
            directoryInfo.GetFile(); // Returns a file list from the current directory.

            directoryInfo.GetDirectories(); // Returns the subdirectories of the current directory.
        }
    }
}
