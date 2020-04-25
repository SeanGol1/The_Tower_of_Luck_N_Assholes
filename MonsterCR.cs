using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosterGenWPF
{
    public class MonsterCR
    {
        public string LVLNumber { get; set; }
        public string LVLDesc { get; set; }

        public MonsterCR(string _lvlnum, string _lvldesc)
        {
            LVLNumber = _lvlnum;
            LVLDesc = _lvldesc;
        }
    }
}
