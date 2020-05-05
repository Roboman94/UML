using StaffClass;
using StudentClass;
using PersonClass;
using System;

namespace MainClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Bill", "1715 Holland Dr.");
            string person2String = p.ToString();

            Student w = new Student("Regis", "1080 Park Dr.");
            string student2String = w.ToString();

            Staff c = new Staff("Vali", "6070 Bull Way");
            string staff2String = c.ToString();
            Console.WriteLine();
            Console.WriteLine("Person class returned: ");
            Console.WriteLine(person2String);
            Console.WriteLine();
            Console.WriteLine("Student class returned: ");
            Console.WriteLine(student2String);
            Console.WriteLine();
            Console.WriteLine("Staff class returned: ");
            Console.WriteLine(staff2String);

        }
    }
}
