using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Projects\CSharpFundamentals\HelloWorld\HelloWorld.sln";
            
            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            
            /*Path Class - Performs operations on String instances that contain file or directory
            path information. These operations are performed in a cross-platform manner.*/
            
            // Returns the extension (including the period ".") of the specified path string.
            Console.WriteLine("Extension" + Path.GetExtension(path));
            
            // Returns the file name and extension of the specified path string.
            Console.WriteLine("File Name" + Path.GetFileName(path));
            
            // Returns the file name of the specified path string without the extension.
            Console.WriteLine("File Name without Extension" + Path.GetFileNameWithoutExtension(path));
            
            // Returns the directory information for the specified path string.
            Console.WriteLine("Directory Name" + Path.GetDirectoryName(path));
        }
    }
}
