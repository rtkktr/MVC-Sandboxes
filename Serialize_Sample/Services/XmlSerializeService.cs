using System.Xml.Serialization;

namespace Serialize_Sample.Services
{
    public static class XmlSerializeService<T> where T : class
    {
        private static XmlSerializer? _serializer;

        public static void Serialize(T entity, string filename)
        {

            _serializer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
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

        public static T? Deerialize(string filename)
        {
            _serializer = new XmlSerializer(typeof(T));
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
    }
}
