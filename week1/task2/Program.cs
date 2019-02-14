using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {

        internal class Student
        {
            string name;
            string id;
            int year;

            public void GetName()
            {
                Console.WriteLine(name);
            }

            public void GetId()
            {
                Console.WriteLine(id);
            }

            public void GetYear()
            {
                Console.WriteLine(year);
            }

            public Student() { name = "Assem"; id = "5651546546"; year = 2018; } // first constructor

            public Student(string n, string i, int y) { name = n; id = i; year = y; } // second constructor




        }
        static void Main(string[] args)
        {
            Student Madi = new Student(); // call for first constructor

            Student Aza = new Student("Aza", "2568512", 2015); // call for second constructor

            Madi.GetName();
            Aza.GetId();
            Madi.GetYear();
        }
    }
}
