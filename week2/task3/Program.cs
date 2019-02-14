using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        
        static void GetSubs (FileSystemInfo fil)
        {
            DirectoryInfo dir = new DirectoryInfo(fil.FullName);
            FileSystemInfo[] subs = dir.GetFileSystemInfos();
            foreach (var sub in subs)
            {
                //Console.Write("         ");
                Console.WriteLine("{0}", sub.Name);

                /*
                if (sub.GetType() == typeof(DirectoryInfo))
                {
                    Console.Write("             ");
                    GetSubs(sub);
                }
                */
                }
        }
        
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\pp2";
            DirectoryInfo dirs = new DirectoryInfo(path);
            FileSystemInfo[] files = dirs.GetFileSystemInfos();

            foreach (var fil in files)
            {
                Console.WriteLine(fil.Name);
                if (fil.GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    GetSubs(fil);
                    /*
                    DirectoryInfo dir = new DirectoryInfo(fil.FullName);
                    FileSystemInfo[] subs = dir.GetFileSystemInfos();
                    foreach (var sub in subs)
                    {
                        Console.WriteLine("     {0}", sub);
                    }
                    */
                }
                else if (fil.GetType() == typeof(FileInfo))
                    Console.ForegroundColor = ConsoleColor.Black;
                
            }
            
            



        }
    }
}
