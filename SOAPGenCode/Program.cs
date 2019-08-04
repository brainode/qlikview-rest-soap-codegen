using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Threading.Tasks;

namespace SOAPGenCode
{
    class Program
    {
        static string InputXmlPath = @"..\..\Data\349.xml";
        static void Main(string[] args)
        {
            XElement soapResponse = XElement.Load(InputXmlPath);
            Console.WriteLine("Test");
        }
    }
}
