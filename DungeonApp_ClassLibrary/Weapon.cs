using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonApp_ClassLibrary
{
    public class Weapon : Item
    {
        public int Damage { get; set; }
        public int AttackSpeed { get; set; }

        public Weapon(string name, int dmg, int atkspd, string description,int itemNumber):base(name, description,itemNumber)
        {
            Damage = dmg;
            AttackSpeed = atkspd;
        }

        public override string ToString()
        {
            return Name;
        }

        public static Weapon WeaponList(int index)
        {
            List<Weapon> weaponList = new List<Weapon>();

            weaponList.Add(new Weapon("Dagger", 1, 20, "Daggers do very little damage but attack rapidly", 001));
            weaponList.Add(new Weapon("Sword", 2, 15, "Swords deal Moderate damage at a fast pace", 002));
            weaponList.Add(new Weapon("Axe", 3, 14, "Axes deal average damage at an average pace", 003));
            weaponList.Add(new Weapon("Club", 2, 12, "Great Axes deal Massive Damage but attack Very slowly", 004));

            weaponList.Add(new Weapon("Long Sword", 4, 10, "Long Swords deal heavy Damage but attack more slowly", 005));
            weaponList.Add(new Weapon("Great Axe", 5, 8, "Great Axes deal Massive Damage but attack Very slowly", 006));

            return weaponList[index -1];
        }
    }
}
