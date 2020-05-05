using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonClass;

namespace StudentClass
{
    public class Student : Person
    {
        protected string sName;
        protected string sAddress;

        public Student(string name, string address)
        {
            this.sName = name;
            this.sAddress = address;  
        }

        public virtual string Program()
        {
            Console.WriteLine($"Enter {sName}'s school program ");
            string program = Console.ReadLine();
            return program;
        }

        public virtual int Year()
        {
            Console.WriteLine("Enter year ");
           string input = Console.ReadLine();
            int year = int.Parse(input);
            return year;
        }

        public virtual double Fee()
        {
            double fee = 0;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Enter fee ");
                string input2 = Console.ReadLine();
                try
                {
                    fee = int.Parse(input2);
                    valid = true;
                 
                }
                catch (FormatException)
                {
                    Console.WriteLine("try again ");
                }
            }
            return fee;
        }

        public override string ToString()
        {
            string prog = Program();
            int year = Year();
            double fee = Fee();
            string result = String.Join(" ", sName, sAddress, prog, year, fee);
            return result;
        }
      
    }
}
