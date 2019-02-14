using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\User\Desktop\pp2\atd.txt";
            //string path1 = @"C:\Users\User\Desktop\pp2";

            string path2 = @"C:\Users\User\Desktop\example.txt";

            FileStream fs = File.Create(path);
            File.Move(path, path2);
            

        }

        
    }
}
