using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonApp_Interfaces;

namespace DungeonApp_ClassLibrary
{
    public class Player : Character , ICombatable
    {
        public Races PlayerRace { get; set; }
        public Weapon MainWeapon { get; set; }
        public Armor? EquippedArmor { get; set; }
        public int Level { get; set; }
        public int Money { get; set; }
        public bool InCombat { get; set; }
        public bool IsSafe { get; set; }
        public bool IsExiting { get; set; }
        public Floor currentFloor { get; set; }


        public Player(string name, Races playerRace, Weapon weapon)
        {
            Name = name;
            PlayerRace = playerRace;
            MainWeapon = weapon;
            Level = 1;
            Money = 0;
            EquippedArmor = null;
            Health = MaxHealth = 10;
            IsAlive = true;
            IsSafe = true;
            InCombat = false;
            IsExiting = false;
            currentFloor = new Floor();
        }
       
        public override string ToString()
        {
            return $"You are {Name} the {PlayerRace} who weilds a {MainWeapon}";
        }
        public int GetDamage()
        {
            return MainWeapon.Damage;
        }

        public int MakeAttack()
        {
            Random rand = new Random();
            return rand.Next(0, 101);
        }

        public int GetDefense()
        {
            Random rand = new Random();
            return rand.Next(0, 101);
        }
        public bool AttackReady()
        {
            if (AttackCoolDown >= 100)
            {
                return true;
            }
            else
            {
                AttackCoolDown += MainWeapon.AttackSpeed;
                return false;
            }

        }
        public void TakeDamage(int dmg)
        {
            Health -= dmg;
            if (Health <= 0) { IsAlive = false; }
        }
    }
}
