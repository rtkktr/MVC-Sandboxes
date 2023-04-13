using Serialize_Sample.Dtos;
using System.Xml.Serialization;

namespace Serialize_Sample.Services
{
    public class PersonService
    {
        private static XmlSerializer? _serializer;

        public static void Serialize(Person person)
        {
            _serializer = new XmlSerializer(typeof(Person));
            using (FileStream fs = new FileStream("xmlPerson.xml", FileMode.OpenOrCreate))
            {
                _serializer.Serialize(fs, person);
            }
        }

        public static Person? Deerialize()
        {
            _serializer = new XmlSerializer(typeof(Person));
            Person? person = null;
            using (FileStream fs = new FileStream("xmlPerson.xml", FileMode.Open))
            {
                person = _serializer.Deserialize(fs) as Person;
            }
            return person;
        }
    }
}
