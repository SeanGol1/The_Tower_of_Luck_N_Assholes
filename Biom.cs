using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosterGenWPF
{
    public class Biom
    {
        public string BiomNumber { get; set; }
        public string BiomDesc { get; set; }

        public Biom(string _number, string _desc)
        {
            BiomNumber = _number;
            BiomDesc = _desc;
        }
    }
}
