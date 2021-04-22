using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerDecorator
{
    public class ToolBox
    {
        public IEnumerable<string> Tools { get; set; }

        public ToolBox()
        {
            Tools = new List<string> { "Wrench", "Hammer" };
        }
    }
}
