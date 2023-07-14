using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OtusHomeWork8
{
    public class Nodes
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public Nodes Right { get; set; }
        public Nodes Left { get; set; }
        public Nodes Parent { get; set; }
        public Nodes (string name, int salary )
        {
            Key = name;
            Value = salary;
        }
    }
}
