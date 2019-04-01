using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckInheritance
{
    class B : A
    {
        int b;
        public B() {
            Console.WriteLine("Class B: Function B");
        }
        public void G() {
            Console.WriteLine("Class B: Function G");
        }
    }
}
