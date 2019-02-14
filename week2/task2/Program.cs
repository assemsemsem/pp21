using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static bool isPrime(int n) //метод для определения простого числа
        {
            int cnt = 0;
            if (n == 1) // exception
                return false;
            else
                {
                    for (int i = 2; i < n; i++) //если число делится на числа в районе от двух до самого числа 
                    {
                        if (n % i == 0)
                            cnt++; // коунтер
                    }
                }

                if (cnt < 1) // означает что число не имеет делителей в этом рейндже и оно является простым
                    return true;
                else
                    return false;
            }

static void Main(string[] args)
        {

            FileStream fs1 = new FileStream(@"C:\Users\User\Desktop\pp2\array.txt", FileMode.Open, FileAccess.Read); //считывание строки с файла
            StreamReader fd = new StreamReader(fs1);

            FileStream fs2 = new FileStream(@"C:\Users\User\Desktop\pp2\write.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter fd2 = new StreamWriter(fs2); //запись результата в файл
            string lines = fd.ReadLine(); // ввод строки
            string[] line = lines.Split(); // объявление массива

            int x;
            for (int i = 0; i < line.Length; i++)
            {
                x = int.Parse(line[i]);
                if (isPrime(x))  //используем метод прайм для каждого элемента массива
                {
                    //Console.WriteLine(line[i]);
                    fd2.WriteLine(line[i]); // выводим простые числа
                }
            }
            fs1.Close(); // закрываем стримы
            fd.Close();
            //fs2.Close();
            fd2.Close();
        }

       
    }
}
