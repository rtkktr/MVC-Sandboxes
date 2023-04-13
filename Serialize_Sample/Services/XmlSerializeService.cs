using Serialize_Sample.Contract;
using System.Xml.Serialization;

namespace Serialize_Sample.Services
{
    public class XmlSerializeService<T> : ISerializer<>
    {
        private readonly XmlSerializer? _serializer;

        public XmlSerializeService(XmlSerializer? serializer)
        {
            _serializer = new XmlSerializer(typeof(T));
        }

        public void Serialize(T entity, string filepath)
        {
            using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                try
                {
                    _serializer.Serialize(fs, entity);
                }
                catch (Exception)
                {
                    return;
                }
                finally { fs.Close(); }
            }
        }

        public T? Deerialize(string filepath)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                try
                {
                    T? t = _serializer.Deserialize(fs) as T;
                    return t;
                }
                catch (Exception)
                {
                    return null;
                }
                finally { fs.Close(); }

            }
        }

        public string Serialize(object value)
        {
            throw new NotImplementedException();
        }
    }
}
