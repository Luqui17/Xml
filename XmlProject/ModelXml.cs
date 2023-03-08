using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlProject
{
    class ModelXml
    {
            public string CnpjEmitente { get; set; }
            public string RzSocialEmitente { get; set; }
            public string CnpjDestinatario { get; set; }
            public string RzSocialDestinatario { get; set; }
            public string XmlKey { get; set; }
            public decimal Value { get; set; }
            public int XmlNumber { get; set; }

            enum XmlType
            {
                Nf_e,
                Ct_e,
                Nfc_E,
                SAT
            };
    }
}
