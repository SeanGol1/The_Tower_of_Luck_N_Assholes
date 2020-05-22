using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosterGenWPF
{
    public class RoomEvent
    {
        public String RoomNumber { get; set; }
        public String EventName { get; set; }
        public RoomEvent(string _rNumber, string _EName)
        {
            RoomNumber = _rNumber;
            EventName = _EName;
        }

    }


}
