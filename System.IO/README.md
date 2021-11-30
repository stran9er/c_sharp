# System.IO

Namespace that contains **all** data types that allow for creation, copying, deletion, movemement, opening of files and directory support.

## File, FileInfo:
* Allows the creation, copying, deleting, moving and opening of files.
* **FileInfo**: Instance methods
* **File**: Static methods
* Some methods included under File, FileInfo:
   * Create()
   * Copy()
   * Delete()
   * Exists()
   * GetAttributes()
   * Move()
   > These are not all the methods under File, FileInfo.  [For more methods, see the MSDN documentation](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0)

## Directory, DirectoryInfo:
* **Directory**: Static methods
   * Methods under Directory include:
      * CreateDirectory()
      * Delete()
      * EnumerateDirectories()
      * Exists()
      >[For more methods, see the MSDN documentation](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0)
* **DirectoryInfo**: Instance methods
   * Methods under DirectoryInfo include:
      * Create()
      * CreateSubDirectory()
      * Delete()
      * GetDirectories()
      >[For more methods, see the MSDN documentation](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0)

## Path:
* Methods under the Path class include:
   * GetDirectoryName()
   * GetFullPath()
   * GetPathRoot()
   * GetRelativePath()
   >[For more methods, see the MSDN documentation](https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=net-6.0)
    
