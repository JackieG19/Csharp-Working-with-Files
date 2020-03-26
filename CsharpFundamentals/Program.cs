using System.IO;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates all the directories in a specified path.
            Directory.CreateDirectory(@"c:\temp\folder1");
            
            // Returns the names of files that meet specified criteria.
            var files = Directory.GetFile(@"c:\projects\CSharpFundamentals", "*.sln", SearchOption.AllDirectories);
            
            foreach(var file in files)
                Console.WriteLine(file);
        }
    }
}
