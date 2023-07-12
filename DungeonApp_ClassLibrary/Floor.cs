using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp_ClassLibrary
{
    public class Floor
    {
        public int Number { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public int LastSafeFloor { get; set; }  
        public Enemy? Enemy { get; set; }

        public Floor()
        {
            LastSafeFloor = Number = 1;
            Description1 = $"Floor {Number}: This is a safe floor to purchase items and heal";
            Description2 = " ";
            Enemy = null;
        }
    }
}
