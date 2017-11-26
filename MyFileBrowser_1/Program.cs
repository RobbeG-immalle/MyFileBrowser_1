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

        }
        static void ShowCurrentDirectory()
        {


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
