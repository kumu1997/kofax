using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Program
    {
        public void Test()
        //public static void Main()
        {
            XDocument variableName = new XDocument(
            new XElement("Root",
            new XElement("Child1", "Data1")
            )
            );

            variableName.Save("C:/Users/Guru/Documents/testxml/dxml1.xml");
        }
    }
}
