using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace XML_Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            Person objPerson = new Person() {FName="Ali",LName="hamidi",Age=20 };
            Person objPerson_des = null;
            XmlSerializer objXmlSerializer = new XmlSerializer(typeof(Person));
            //using (FileStream objFileStream=new FileStream("xmlPerson.xml",FileMode.Create))
            //{
            //    objXmlSerializer.Serialize(objFileStream,objPerson);
            //}

            using (FileStream fs=new FileStream("xmlPerson.xml",FileMode.Open))
            {
                objPerson_des = objXmlSerializer.Deserialize(fs) as Person;
            }
            Console.WriteLine(objPerson_des.FName);
            Console.WriteLine(objPerson_des.LName);
            Console.WriteLine(objPerson_des.Age);
            System.Console.ReadLine();
        }
    }
}
