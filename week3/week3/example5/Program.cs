using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example5
{
    class Program
    {
        static void Main(string[] args)
        {
            // string copypath = @"C:\Users\User\Desktop\example";
            DirectoryInfo dirs = new DirectoryInfo(@"C:\Users\User\Desktop\pp2");
            // DirectoryInfo copy = new DirectoryInfo(copypath);

            // FileSystemInfo[] cop = copy.GetFileSystemInfos();
            FileSystemInfo[] files = dirs.GetFileSystemInfos();
            for (int i = 0; i < files.Length; i++)
            {
                Console.WriteLine("{0}. {1}",i, files[i]);
            }

            

        }
    }
}
