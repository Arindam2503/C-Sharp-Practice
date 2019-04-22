using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(C);
            object[] a = t.GetCustomAttributes(typeof(Comment), true);
            Comment ca = (Comment)a[0];
            Console.WriteLine(ca.Text + ", " + ca.Author);
        }
    }
}
