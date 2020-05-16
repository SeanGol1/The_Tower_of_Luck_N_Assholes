using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosterGenWPF
{
    public class Monster
    {
        public string MonsterCR { get; set; }
        public string MonsterName { get; set; }
        public string MMPage { get; set; }
        public string MonsterRdNumber { get; set; }

        public string imagepath { get; set; }

        public Monster(string _MonsterCR, string _name, string _page)
        {
            MonsterCR = _MonsterCR;
            MonsterName = _name;
            MMPage = _page;
            imagepath = MonsterName + ".png";

        }

        public Monster(string _MonsterCR, string _name, string _page,string _number)
        {
            MonsterCR = _MonsterCR;
            MonsterName = _name;
            MMPage = _page;
            MonsterRdNumber = _number;

        }
    }
}
