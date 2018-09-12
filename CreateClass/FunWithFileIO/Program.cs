using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;

namespace FunWithFileIO
{
    class Program
    {
        static string Path = @"d:\codecool\dotnet\dotNET-SI-gyertya\temp\fileIOtest.txt";
        static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();

        static void Main(string[] args)
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(Environment.GetLogicalDrives()[0]);
            System.IO.DirectoryInfo rootDir = di.RootDirectory;
            Console.WriteLine(di);
            WalkDirecoryTree(di.RootDirectory);

            //MyFileCreateTextMethod();
            //ListAllFilesFromComputer(); // It takes too long time :)
        }

        private static void ListOfAllDirs()
        {
            System.IO.DriveInfo di = new System.IO.DriveInfo(Environment.GetLogicalDrives()[0]);
            System.IO.DirectoryInfo rootDir = di.RootDirectory;
            Console.WriteLine(di);
            Console.WriteLine(rootDir.GetDirectories());
        }

        private static void ListAllFilesFromComputer()
        {
            string[] drives = System.Environment.GetLogicalDrives();

            foreach (string dr in drives)
            {
                System.IO.DriveInfo di = new System.IO.DriveInfo(dr);

                Console.WriteLine($"drive: {di.Name}, {di.VolumeLabel}");
                System.IO.DirectoryInfo rootDir = di.RootDirectory;
                WalkDirecoryTree(rootDir);
            }
            Console.WriteLine("Files with restricted access: ");
            foreach (string s in log)
            {
                Console.WriteLine(s);
            }
        }

        private static void WalkDirecoryTree(DirectoryInfo root)
        {
            System.IO.FileInfo[] files = null;
            System.IO.DirectoryInfo[] subDirs = null;

            //try
            //{
            //    files = root.GetFiles("*.*");
            //}
            //catch (UnauthorizedAccessException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (System.IO.DirectoryNotFoundException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //if (files != null)
            //{
            //    foreach (System.IO.FileInfo file in files)
            //    {
            //        Console.WriteLine(file.FullName);
            //    }

            subDirs = root.GetDirectories();

            foreach (System.IO.DirectoryInfo dir in subDirs)
            {
                WalkDirecoryTree(dir);
                Console.WriteLine(dir);
            }
            //}
        }

        private static void MyFileCreateTextMethod()
        {

            if (!File.Exists(Path))
            {
                using (StreamWriter sw = File.CreateText(Path))
                {
                    sw.Write("Hello");
                    sw.WriteLine(" World!");
                    sw.WriteLine(Path);

                    //the current directory may differ from the execution folder
                    sw.WriteLine(Directory.GetCurrentDirectory());
                    //differentiate between the executing assembly, the entry assembly or any other loaded assembly
                    sw.WriteLine(System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location));

                }
            }

            using (StreamReader sr = File.OpenText(Path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
