using System;

namespace IODemo //reads a directory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            System.IO.Directory.CreateDirectory(@"c:\Allfiles\glen");
            System.IO.DirectoryInfo dirinfo = new System.IO.DirectoryInfo(@"c:\Allfiles");
            foreach(var subdir in dirinfo.GetDirectories())
            {
                Console.WriteLine(subdir.Name);
                Console.WriteLine(subdir.CreationTime); //shows creation time
                Console.WriteLine(subdir.Attributes);
                Console.WriteLine(subdir.CreationTimeUtc);
            }
            Console.ReadLine();
        }
    }
}
