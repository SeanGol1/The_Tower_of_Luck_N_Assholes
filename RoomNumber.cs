using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosterGenWPF
{
    public class RoomNumber
    {
        public string Number { get; set; }
        public string Room { get; set; }

        public RoomNumber(string _number,string _room)
        {
            Number = _number;
            Room = _room;
        }
    }


}
