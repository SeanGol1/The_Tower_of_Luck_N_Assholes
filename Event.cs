using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosterGenWPF
{
    public class Event
    {
        public string EventNumber { get; set; }
        public string EventDesc { get; set; }
        public Event(string _number,string _desc)
        {
            EventNumber = _number;
            EventDesc = _desc;
        }
    }
}
