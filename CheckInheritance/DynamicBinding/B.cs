using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicBinding
{
    public class B : A
    {
        public override void WhoAreYou() {
            Console.WriteLine("I am a B");
        }
    }
}
