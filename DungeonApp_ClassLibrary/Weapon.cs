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
        public int Price { get; set; }
        public Weapon(string name, int dmg, int atkspd, string description,int itemNumber, int price):base(name, description,itemNumber)
        {
            Damage = dmg;
            AttackSpeed = atkspd;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}: {Description} Price: {Price} gold";
        }

        public static Weapon WeaponList(int index)
        {
            List<Weapon> weaponList = new List<Weapon>();

            weaponList.Add(new Weapon("Dagger", 1, 50, "Daggers do very little damage but attack rapidly", 001, 1));
            weaponList.Add(new Weapon("Sword", 2, 40, "Swords deal Moderate damage at a fast pace", 002, 2));
            weaponList.Add(new Weapon("Axe", 3, 35, "Axes deal average damage at an average pace", 003, 2));
            weaponList.Add(new Weapon("Club", 2, 30, "Great Axes deal Massive Damage but attack Very slowly", 004, 1));

            weaponList.Add(new Weapon("Long Sword", 4, 15, "Long Swords deal heavy Damage but attack more slowly", 005, 5));
            weaponList.Add(new Weapon("Great Axe", 5, 10, "Great Axes deal Massive Damage but attack Very slowly", 006, 6));

            return weaponList[index -1];
        }
    }
}
