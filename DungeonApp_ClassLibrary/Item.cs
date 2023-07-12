using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp_ClassLibrary
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemNumber { get; set; }

        public Item(string name, string description, int itemNumber)
        {
            Name = name;
            Description = description;
            ItemNumber = itemNumber;
        }
    }

}
