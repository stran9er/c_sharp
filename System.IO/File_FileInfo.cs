using System;

namespace File_FileInfo
{
  class Program 
  {
    static void Main (string[] args)
    {
      // File location, copied to new location, and override if exists.
      File.Copy(@"c:\temp\file.txt", @"c:\temp_two\file.txt", true)
      
      var MyPath = @"c:\somepath\file.txt";
      File.Delete(MyPath);
      
    }
  }
}

