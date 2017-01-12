using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_demo2
{
    class Student
    {
        string name;
        int age;
        double rate;

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        public Student(string name, int age, double rate)
        {
            this.name = name;
            this.age = age;
            this.rate = rate;
        }

        public override string ToString()
        {
            return String.Format("{0, 10}{1, 7} years{2, 7}",
                name, age, rate);
        }
    }
}
