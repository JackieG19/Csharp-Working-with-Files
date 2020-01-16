using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpg";
            
            // Copies an existing file to a new file.
            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true)
            
            // Deletes the specified file.
            File.Delete(path);
            
            if(File.Exists(path)) // Determines whether the specified file exists.
            {
                /*File class - Provides static methods for the creation, copying, deletion, moving, 
                and opening of a single file, and aids in the creation of FileStream objects.*/
            }
        }
    }
}
