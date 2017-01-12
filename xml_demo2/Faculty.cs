using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_demo2
{
    class Faculty
    {
        string name;
        public Dictionary<string, Group> groups;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Faculty()
        {
            groups = new Dictionary<string, Group>();
        }

        public void AddGroup(Group g)
        {
            groups.Add(g.Name, g);
        }

        public void DelGroup(string name)
        {
            groups.Remove(name);
        }
    }
}
