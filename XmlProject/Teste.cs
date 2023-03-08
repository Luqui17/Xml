using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using MongoDB.Bson;
using MongoDB.Driver;

namespace XmlProject
{
    class Teste
    {
        static void Main(string[] args)
        {

            Service service = new Service();
            service.depois();
            Console.ReadLine();


            //XDocument doc = XDocument.Load(@"C:\Users\Pichau\Documents\XmlsProject\teste.xml");
            //var query = from d in doc.Descendants("emit") select new { Nome = d.Attribute("CNPJ").Value };
             


            //query.ToList().ForEach(s => { Console.WriteLine(s.Nome.ToString()); });
            //Console.ReadLine();
        }
    }
}
