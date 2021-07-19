using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConceptsExample
{
    class XMLtoJSON
    {
        public static void Method(ref string i,out int j)
        {
            i = "Srinivas";
            j = 10;
        }


        public static void Main()
        {
            string xml = @"<Invoice>
                            <Timestamp>1/1/2017 00:01</Timestamp>
                            <CustNumber>12345</CustNumber>
                            <AcctNumber>54321</AcctNumber>
                        </Invoice>";

            var newxml = @"<invoive Timestamp='1/1/2017 00:01' CustNumber='12345' />";

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(xml);

            var json = JsonConvert.SerializeXmlNode(xdoc, Newtonsoft.Json.Formatting.Indented, true);

            string p="";
            int j;
            Method(ref p,out j);
        }
    }
}
