using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml_demo2
{
    class DataManager
    {
        XmlDocument doc;
        Faculty fac;
        string path;
        XmlNode root;

        public DataManager()
        {
            doc = new XmlDocument();
            fac = new Faculty();
            path = @"..\..\faculty.xml";
            LoadData();
        }

        void LoadData()
        {
            doc.Load(path);
            root = doc.DocumentElement;
            foreach (XmlNode group in root.ChildNodes)
            {
                Group g = new Group(group.Attributes["name"].Value);
                foreach(XmlNode student in group.ChildNodes)
                {
                    Student s = new Student(
                        student.Attributes["name"].Value,
                        Convert.ToInt32(student.Attributes["age"].Value),
                        Convert.ToDouble(student.Attributes["rate"].Value)
                    );
                    g.AddStudent(s);
                }
                fac.AddGroup(g);
            }
        }

        void SaveData()
        {
            root.RemoveAll();
            foreach (Group x in fac.groups.Values)
            {
                XmlElement g = doc.CreateElement("group");
                g.SetAttribute("name", x.Name);
                foreach (Student y in x.students.Values)
                {
                    XmlElement s = doc.CreateElement("student");
                    s.SetAttribute("name", y.Name);
                    s.SetAttribute("age", y.Age.ToString());
                    s.SetAttribute("rate", y.Rate.ToString());
                    g.AppendChild(s);
                }
                root.AppendChild(g);
            }
        }

        public void Display()
        {
            foreach (Group g in fac.groups.Values)
            {
                g.Display();
            }
        }
    }
}
