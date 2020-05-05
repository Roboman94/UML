using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonClass;

namespace StaffClass
{
    public class Staff : Person
    {
        protected string sName;
        protected string sAddress;

        public Staff(string name, string address)
        {
            this.sName = name;
            this.sAddress = address;
        }

        public virtual string School()
        {
            Console.WriteLine($"Enter {sName} school ");
            string school = Console.ReadLine();
            return school;
        }

        public virtual double Pay()
        {
            double pay = 0;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("Enter pay ");
                string input2 = Console.ReadLine();
                try
                {
                    pay = int.Parse(input2);
                    valid = true;
                  
                }
                catch (FormatException)
                {
                    Console.WriteLine("try again ");
                }
            }
            return pay;
        }

        public override string ToString()
        {
            string school = School();
            double pay = Pay();
            string result = String.Join(" ", sName, sAddress, school, pay);
            return result;
        }
    }
}
