using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void DoubleArr(string s)
        {

            string[] arr = s.Split();
            for (int i = 0; i < arr.Length; i++)
            {
                int x;
                x = int.Parse(arr[i]);
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
        }
        static void Main(string[] args)
        {
            string t;
            t = Console.ReadLine();
            string s;
            s = Console.ReadLine();
           

            DoubleArr(s);

        }
    }
}
