using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace MyFileBrowser_1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                ShowDefault();
            }
            else
            {
                switch (args[0])
                {
                    case "-c":
                        ShowCurrentDirectory();
                        break;
                    case "-f":
                        ShowAllFilesInCurrentDirectory();
                        break;
                    case "-d":
                        ShowAllSubDirectories();
                        break;
                    case "-h":
                        ShowHelp();
                        break;

                    default:
                        Console.WriteLine("Onbekend argument");
                        break;
                }
            }
        }
        static void ShowDefault()
        {
            Console.WriteLine("Current Directory:");
            ShowCurrentDirectory();
            Console.WriteLine("Alle Subdirectories:");
            ShowAllSubDirectories();
            Console.WriteLine("Alle files:");
            ShowAllFilesInCurrentDirectory();
        }
        static void ShowCurrentDirectory()
        {
            Console.WriteLine("Current Directory:" + System.IO.Directory.GetCurrentDirectory());
        }
        static void ShowAllFilesInCurrentDirectory()
        {
            string[] dirs = Directory.GetFiles(Environment.CurrentDirectory);
            foreach (string dir in dirs)
            {
                Int64 fileSizeInBytes = new FileInfo(dir).Length;
                Console.WriteLine(Path.GetFileName(dir) + "         " + fileSizeInBytes + " bytes");
            }
            Console.WriteLine();
        }
        static void ShowAllSubDirectories()
        {
            string[] fileArray = Directory.GetDirectories(Environment.CurrentDirectory);
            for (int i = 0; i < fileArray.Length; i++)
            {

                Console.WriteLine(fileArray[i]);
            }
        }
        static void ShowHelp()
        {
            Console.WriteLine("Help - ofb = MyFileBrowser.exe:");
            Console.WriteLine("- mfb -c: Toont de huidige directory");
            Console.WriteLine("- mfb -d: Toont alle subdirectories in  de huidige directory");
            Console.WriteLine("- mfb -f: Toont alle files in de huidige directory");
            Console.WriteLine("- mfb: Toont de huidige directory, files en subdirectories");
            Console.WriteLine("- mfb -h: Toont help");
        }

    }

}
