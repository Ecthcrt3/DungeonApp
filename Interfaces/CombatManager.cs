using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp_Interfaces
{
    public class CombatManager
    {
        public static bool CalculateHit(ICombatable attacker, ICombatable target)
        {
            return attacker.MakeAttack() > target.GetDefense();
        }
        
        public static bool CalculateRun(ICombatable runner, ICombatable attacker)
        {
            return true;
        }
    }
}
