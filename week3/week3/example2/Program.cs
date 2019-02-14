using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace example2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\pp2";
            string subpath = @"program\djhfjd";
            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);

            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine( dirInfo.CreationTime);
            Console.WriteLine(dirInfo.Root);


        }
    }
}
