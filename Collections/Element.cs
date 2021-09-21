using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Element
    {
        private string name;
        private int field1;
        private int field2;

        public Element(string name, int field1, int field2)
        {
            this.name = name;
            this.field1 = field1;
            this.field2 = field2;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Field1
        {
            get { return field1; }
            set { field1 = value; }
        }
        public int Field2
        {
            get { return field2; }
            set { field2 = value; }
        }
    }
}
