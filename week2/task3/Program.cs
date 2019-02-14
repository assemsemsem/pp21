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
        static string Otstup(int a) // метод для генерации пробелов
        {
            string s = "      ";
            string p = "";
            for (int i = 0; i < a; i++)
            {
                p += s;
            }
            return p;
        }
        static void info(DirectoryInfo dir, int a) // вывод содержания папок
        {
            FileInfo[] files = dir.GetFiles();
            DirectoryInfo[] dires = dir.GetDirectories();
            foreach (FileInfo file in files) //ьл
            {

                Console.Write(Otstup(a));
                Console.WriteLine(file.Name);
            }
            foreach (DirectoryInfo dire in dires) // вывод названия папок с определенным расстоянием
            {
                Console.Write(Otstup(a)); // объявляем метод Space
                Console.WriteLine(dire.Name);
                info(dire, a + 1);
            }
        }

        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\IDE");
            info(dir, 0);
            
        }
    }
}
