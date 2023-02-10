using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ta_Boss_věc
{
    public class Class1
    {
        public int select { get; set; }
        public static Class1 ins;
        public Class1()
        {
            ins = this;
        }
    }
    class Class2 
    {
        public int select2 { get; set; }
    }
}
