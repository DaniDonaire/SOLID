using SingleResponsibility;
using System;
using System.Collections.Generic;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsability:");
            

            Student student = new Student("Dani","Test");
            List<Student> students = new List<Student>();
            students = Lists<Student>.AddToList(students, student);

            Console.ReadLine();



            Console.WriteLine("Go to Single Responsability!");
            Console.WriteLine("Go to Single Responsability!");
            Console.WriteLine("Go to Single Responsability!");
            Console.ReadLine();

        }
    }
}
