using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MosterGenWPF
{
    public class Item
    {
        public string ItemName { get; set; }
        public string ItemCost { get; set; }
        public string Vendor { get; set; }

        public Item(string _name, string _cost, string _vendor)
        {
            ItemName = _name;
            ItemCost = _cost;
            Vendor = _vendor;
        }
    }
}
