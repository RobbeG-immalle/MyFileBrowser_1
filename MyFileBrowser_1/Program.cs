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

        }
        static void ShowAllSubDirectories()
        {

        }
        static void ShowHelp()
        {

        }

    }

}
