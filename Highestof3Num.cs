using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConceptsExample
{
    class Highestof3Num
    {

        public static void Main()
        {
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");


            string xml = @"
                        <Invoice>
                            <Timestamp>1/1/2017 00:01</Timestamp>
                            <CustNumber>12345</CustNumber>
                            <AcctNumber>54321</AcctNumber>
                        </Invoice>";

            var newxml = @"<invoive Timestamp='1/1/2017 00:01' CustNumber='12345' />";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            //xml to json conversion 
            var json = JsonConvert.SerializeXmlNode(doc, Newtonsoft.Json.Formatting.Indented, true);
            Console.WriteLine(json);

            //json to xml conversion
            XmlDocument xdoc = JsonConvert.DeserializeXmlNode(json);
            Console.WriteLine(xdoc);

            Console.ReadKey();
        }
    }
}
