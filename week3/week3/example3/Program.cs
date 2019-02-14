using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example3
{
    class Program
    {
        class Layer
        {

        }
        static void Main(string[] args)
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\User\Desktop\pp2");

            FileSystemInfo[] dirs = dirinfo.GetFileSystemInfos();

            for (int i = 0; i < dirs.Length; ++i)
            {
                Console.WriteLine("{0}. {1}", i, dirs[i]);
            }
        }
    }
}
