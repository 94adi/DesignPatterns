using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSerialize.SerializeService
{
    public interface ISerialize
    {
        string Serialize(object obj);
    }
}
