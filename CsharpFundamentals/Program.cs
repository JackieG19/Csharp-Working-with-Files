using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true)
            File.Delete(path);
            if(File.Exists(path)) 
            {
                //
            }
            var content = File.ReadAllText(path);
            
            var fileInfo = new FileInfo(path);
            
            fileInfo.CopyTo("..."); // Copies an existing file to a new file.
            
            fileInfo.Delete(); // Permanently deletes a file.
            
            if(fileInfo.Exists) // Gets a value indicating whether a file exists.
            {
                /*FileInfo class - Provides properties and instance methods for the creation, copying, deletion, moving, 
                and opening of files, and aids in the creation of FileStream objects. This class cannot be inherited.*/
            }
        }
    }
}
