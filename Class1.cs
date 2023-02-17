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
    public class Class2 
    {
        public int mission { get; set; }
        public static Class2 ins;
        public Class2()
        {
            ins = this;
        }
    }
    public class Class3
    {
        public int scene { get; set; }
        public static Class3 ins;
        public Class3()
        {
            ins = this;
        }
    }
}
