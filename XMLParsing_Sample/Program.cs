using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XMLParsing_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\users\user\documents\visual studio 2015\Projects\XMLParsing_Sample\XMLParsing_Sample\Customers.xml");

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/Customers/CustomerDetails");

            foreach (XmlNode item in nodes)
            {
                Console.Write(item.SelectSingleNode("Name").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Address1").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Address2").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Address3").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Address4").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Postcode").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Telephone").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Mobile").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Fax").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Email/WorkEmail").InnerText + "\t");
                Console.Write(item.SelectSingleNode("Email/PersonalEmail").InnerText + "\t");

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
