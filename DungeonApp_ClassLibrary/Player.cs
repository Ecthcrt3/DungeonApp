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
        public int Experience { get; set; }


        public Player(string name, Races playerRace, Weapon weapon)
        {
            Name = name;
            PlayerRace = playerRace;
            MainWeapon = weapon;
            Level = 1;
            Money = 0;
            EquippedArmor = null;
            MaxHealth = 10;
            Health = MaxHealth;
            IsAlive = true;
            IsSafe = true;
            InCombat = false;
            IsExiting = false;
            currentFloor = new Floor();
            AttackCoolDown = 0;
            Experience = 0;
            GetStats(playerRace);
        }
       
        private void GetStats(Races playerRace)
        {
            switch (playerRace)
            {
                case Races.Human:
                    Attack = 5;
                    Defense = 5;
                    break;
                case Races.Elf:
                    Attack = 3;
                    Defense = 7;
                    break;
                case Races.Dwarf:
                    Attack = 7;
                    Defense = 3;
                    break;
                case Races.Halfling:
                    Attack = 4;
                    Defense = 6;
                    break;
                case Races.Teifling:
                    Attack = 6;
                    Defense = 4;
                    break;
            }
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
            return (rand.Next(0, 101) + Attack);
        }

        public int GetDefense()
        {
            Random rand = new Random();
            return (rand.Next(0, 101) + Defense);
        }
        public bool AttackReady()
        {
            if (AttackCoolDown >= 100)
            {
                AttackCoolDown -= 100;
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
        public void GetXP(int xp)
        {
            Experience += xp;
            if(Experience >= Level * 10)
            {
                Experience -= Level * 10;
                Level++;
                MaxHealth += 10;
                Health = MaxHealth;
                if(new Random().Next(0, 101) <= 50)
                {
                    Defense++;
                }
                else
                {
                    Attack++;
                }
            }
        }
    }
}
