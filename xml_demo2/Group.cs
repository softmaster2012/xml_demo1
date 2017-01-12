using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_demo2
{
    class Group
    {
        string name;
        public Dictionary<string, Student> students;

        public string Name
        {
            get { return name; }
        }

        public Group(string name)
        {
            this.name = name;
            students = new Dictionary<string, Student>();
        }

        public void AddStudent(Student x)
        {
            students.Add(x.Name, x);
        }

        public void DelStudent(string name)
        {
            students.Remove(name);
        }

        public Student FindStudent(string name)
        {
            if (students.ContainsKey(name))
                return students[name];
            else
                return null;
        }

        public void Display()
        {
            Console.WriteLine("\n> Group {0}:", name);
            foreach (KeyValuePair<string, Student> p in students)
                Console.WriteLine(p.Value);         
        }
    }
}
