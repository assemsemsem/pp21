using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 done well
 */
namespace task1
{
    class Program
    {
     
        static void CheckPalind(string t) //метод для определения палиндрома
        {
            
            bool isp = true;
            for (int i = 0; i < t.Length / 2; i++)
            {
                if (t[i] != t[t.Length - i - 1]) // если одна из симметричных пар не будет совпадать
                    isp = false;
            }

            if (isp)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
       


        static void Main(string[] args)
        {

            FileStream ff = new FileStream(@"C:\Users\User\Desktop\pp2\example.txt", FileMode.Open, FileAccess.Read); // для чтения строки с файла

            StreamReader fs = new StreamReader(ff);

            string line = fs.ReadLine();

            
            //Console.WriteLine(line); проверка чтения файла
            CheckPalind(line); //объявляем метод

            ff.Close(); //закрываем стримфайлы и ридеры
            fs.Close();
        }
    }
}
