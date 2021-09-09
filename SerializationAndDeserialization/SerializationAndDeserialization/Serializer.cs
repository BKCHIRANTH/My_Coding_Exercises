using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;



namespace SerializationAndDeserialization
{
    //public class Serializer
    //{
    //public T Deserialize<T>(string input) where T : class
    //{
    //    XmlSerializer ser = new XmlSerializer(typeof(T));

    //    using (StringReader sr = new StringReader(input))
    //    {
    //        return (T)ser.Deserialize(sr);
    //    }
    //}

    //public string Serialize<T>(T ObjectToSerialize)
    //{
    //    XmlSerializer xmlSerializer = new
    //       XmlSerializer(ObjectToSerialize.GetType());

    //    using (StringWriter textWriter = new StringWriter())
    //    {
    //        xmlSerializer.Serialize(textWriter, ObjectToSerialize);
    //        return textWriter.ToString();
    //    }
    //}


    public class Serializer<T>

    {

        StringBuilder sbData;

        StringWriter swWriter;

        XmlDocument xDoc;

        XmlNodeReader xNodeReader;

        XmlSerializer xmlSerializer;

        public Serializer()

        {

            sbData = new StringBuilder();

        }

        public string SerializeData(T data)

        {

            XmlSerializer studentSerializer = new XmlSerializer(typeof(T));

            swWriter = new StringWriter(sbData);

            studentSerializer.Serialize(swWriter, data);

            return sbData.ToString();

        }



        public T DeserializeData(string dataXML)

        {

            xDoc = new XmlDocument();

            xDoc.LoadXml(dataXML);

            xNodeReader = new XmlNodeReader(xDoc.DocumentElement);

            xmlSerializer = new XmlSerializer(typeof(T));

            var studentData = xmlSerializer.Deserialize(xNodeReader);

            T deserializedstudent = (T)studentData;

            return deserializedstudent;

        }

    }
}
