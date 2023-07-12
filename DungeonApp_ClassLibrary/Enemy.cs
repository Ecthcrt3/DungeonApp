using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonApp_Interfaces;

namespace DungeonApp_ClassLibrary
{
    public class Enemy : Character, ICombatable
    {
        public string Description { get; set; }
        public int AttackSpeed { get; set; }

        public Enemy(string name, int maxHealth, int attack, int defense, int attackSpeed, string description) : base(name, maxHealth, attack, defense)
        {
            Description = description;
        }

        public static Enemy RandomEnemy()
        {
            List <Enemy> enemyList = new List<Enemy>();
            enemyList.Add(new Enemy("bunny", 2, 0, 1, 10,"A cute bunny rabbit"));
            return enemyList[0];
        }
        public int GetDamage()
        {
            return Attack;
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
                AttackCoolDown += AttackSpeed;
                return false;
            }

        }
        public void TakeDamage(int dmg)
        {
            Health -= dmg;
            if(Health <= 0) { IsAlive = false; }
        }
    }
}
