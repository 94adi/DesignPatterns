using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSerialize.SerializeService
{
    public class JsonSerializer : ISerialize
    {
        public string Serialize(object obj)
        {
            var result = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            return result;
        }
    }
}
