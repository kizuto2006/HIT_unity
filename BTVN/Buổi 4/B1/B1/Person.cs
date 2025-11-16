using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    internal class Person
    {
        private string FullName;
        private int Age;
        private int Add;
        public string FullName
        {
            get { return FullName; }
            set { FullName = value; }
        }
        public int Age
        {
            get { return Age; }
            set { Age = value; }
        }
        public string Add
        {   
            get { return Add; } 
            set {Add = value; } 
        }
        public Person(string fullName, int age, string add)
        {
            FullName = fullName;
            Age = age;
            Add = add;
        }
        public Person()
        {
            FullName = "";
            Age = 4;
            Add = "";
        }

    }
}
