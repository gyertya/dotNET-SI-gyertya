using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace SeekAndArchive
{
    class Program
    {
        static readonly string Path = @"D:\codecool\dotnet\dotNET-SI-gyertya\CreateClass\SeekAndArchive\TheDirectory\";
        static string Checker = "lastCheck.txt";

        static List<FileInfo> ChangedFiles = new List<FileInfo>();

        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles(Path);
            string[] directories = Directory.GetDirectories(Path);

            var LastCheck = GetLastCheck();

            bool MakeAnArchive = IsArchiveNeeded(files, LastCheck);

            string logFileName = SetLastCheck();

            if (MakeAnArchive)
            {
                Console.WriteLine("Something changed");
                string archivePath = Path + @"\archives\";
                string zipPath = archivePath + "change" + logFileName + ".zip";

                ZipFile.CreateFromDirectory(Path, zipPath); //something wrong here
            }
        }

        private static bool IsArchiveNeeded(string[] files, DateTime LastCheck)
        {
            bool archiveIsNeeded = false;
            foreach (var file in files)
            {
                Console.WriteLine(file);
                FileInfo fi = null;
                try
                {
                    fi = new FileInfo(file);
                }
                catch (UnauthorizedAccessException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                if (LastCheck < fi.LastWriteTime)
                {
                    archiveIsNeeded = true;
                    Console.WriteLine(fi);
                    ChangedFiles.Add(fi);
                }
            }
            return archiveIsNeeded;
        }

        static DateTime GetLastCheck()
        {
            string lastCheckDate = null;
            try
            {
                lastCheckDate = File.ReadAllText(Path + Checker);
            }
            catch (Exception)
            {
                lastCheckDate = "1/1/0001";
            }
            return DateTime.Parse(lastCheckDate);
        }

        static string SetLastCheck()
        {
            DateTime saveTime = DateTime.Now;
            using (StreamWriter sw = File.CreateText(Path + Checker))
            {
                sw.Write(saveTime);
            }
            return saveTime.ToFileTime().ToString();
        }
    }
}
