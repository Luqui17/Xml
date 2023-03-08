using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlProject
{
    class Service
    {
        public  void depoisEuVejo()
        {
            XElement Xelement = XElement.Load(@"C:\Users\Pichau\Documents\XmlsProject\teste.xml");

            IEnumerable<XElement> books = Xelement.Elements();

            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
            Console.ReadLine();
        }
        public void depois()
        {
            XElement element = XElement.Load(@"C:\Users\Pichau\Documents\XmlsProject\teste.xml");
            
            IEnumerable<XElement> Nfs = element.Elements();

            var teste = from d in Nfs select new { Nome = d.Element("CNPJ").Value };
            foreach (var ad in teste)
            {
                Console.WriteLine(ad);
            }
        }
    }
}
