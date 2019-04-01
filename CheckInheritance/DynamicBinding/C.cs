using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    class C :B
    {
        public new virtual void WhoAreYou()
        { Console.WriteLine("I am a C");
        }
    }
}
