using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine(drive.Name);
                Console.WriteLine(drive.DriveType);
                if (drive.IsReady)
                {
                    Console.WriteLine(drive.TotalSize);
                    Console.WriteLine(drive.TotalFreeSpace);
                    Console.WriteLine(drive.VolumeLabel);
         
                }
            }
        }
    }
}
