using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml_demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataManager dm = new DataManager();
                dm.Display();                
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }
    }
}
