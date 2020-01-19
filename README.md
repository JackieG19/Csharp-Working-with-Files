## Working with file

**System.IO**
- File, FileInfo
	- Provide methods for creating, copying, deleting, moving and opening of files
	- *FileInfo*: provides instance methods
	- *File*: provides static methods
	- Create() - creates or overwrites a file in the specified path.
  - Copy() - copies an existing file to a new file.
  - Delete() - deletes the specified file.
  - Exists() - determines whether the specified file exists.
  - GetAttributes() - gets the FileAttributes of the file on the path.
  - Move() - moves a specified file to a new location, providing the option to specify a new file name.
  - ReadAllText() - opens a text file, reads all the text in the file into a string, and then closes the file.

- Directory, DirectoryInfo
	- *Directory*: provides instance methods
	- *DirectoryInfo*: provides instance methods
	- CreateDirectory() - creates all the directories in a specified path.
  - Delete() - deletes an empty directory from a specified path.
  - Exists() - determines whether the given path refers to an existing directory on disk.
  - GetCurrentDirectory() - gets the current working directory of the application.
  - GetFile() - returns the names of files (including their paths) in the specified directory.
  - Move() - moves a file or a directory and its contents to a new location.
  - GetLogicalDrives() - retrieves the names of the logical drives on this computer in the form "<drive letter>:\"
	
- Path
	- GetDirectoryName() - returns the directory information for the specified path string.
	- GetFileName() - returns the file name and extension of the specified path string.
	- GetExtension() - returns the extension (including the period ".") of the specified path string.
	- GetTempPath() - returns the path of the current user's temporary folder.
___

Next -> [Debugging Applications](https://github.com/JackieG19/Csharp-Debugging-Applications)
