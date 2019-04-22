using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attributes
{
    class Comment : Attribute
    {
        string text, author;
        public string Text { get { return text; } }
        public string Author { get { return author; } set { author = value; } }
        public Comment(string text)
        {
            this.text = text; author = "HM";
        }
    }
}
