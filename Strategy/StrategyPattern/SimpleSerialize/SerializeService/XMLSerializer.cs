using SimpleSerialize.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SimpleSerialize.SerializeService
{
    public class XMLSerializer<T> : ISerialize
    {
        public string Serialize(object obj)
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(T));
            string s = "";
            using (StringWriter fStream = new StringWriter())
            {
                xmlFormat.Serialize(fStream, obj);
                s = fStream.ToString();
            }
            return s;
        }
    }
}
