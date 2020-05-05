using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass
{
    public class Person
    {
        protected string Name;
        protected string Address;

        public string name { get; set; }
        public string address { get; set; }
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public Person() { }

        public override string ToString()
        {
            string result = String.Join(" ", name, address);
            return result;
        }

    }
}
