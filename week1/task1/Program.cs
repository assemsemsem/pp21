using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static bool isPrime(int n) //creating a function that checks a number for being a prime
        {
            int cnt = 0; 
            if (n == 1) // exception
                return false;
            else
            {
                for (int i = 2; i < n; i++) //determinig a range from 2 to the number itself 
                {
                    if (n % i == 0)
                        cnt++; // counter 
                }
            }

            if (cnt < 1) // if number is not divisible to any number in a given range then it is prime
                return true;
            else
                return false;
        }



        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            int n;
            n = int.Parse(s);
            string line;
            line = Console.ReadLine();
            string[] arr = line.Split(); //array 


            int x, cnt = 0;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(arr[i]);

                if (isPrime(x))  //calling a function
                    cnt++;

            }

            Console.WriteLine(cnt);

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(arr[i]);
                

                if (isPrime(x))
                {
                    Console.Write($"{arr[i]} ");
                }

               

            }
        }
    }
}
