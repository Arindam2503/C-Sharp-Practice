using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            C c = new D();
            c.WhoAreYou(); // "I am a D"
            A a = new D();
            a.WhoAreYou(); // "I am a B" !!
        }
    }
}
