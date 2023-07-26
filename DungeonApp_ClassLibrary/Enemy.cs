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
        public int Reward_XP { get; set; }
        public int Reward_Money { get; set; }

        public Enemy(string name, int maxHealth, int attack, int defense, int attackSpeed, string description) : base(name, maxHealth, attack, defense)
        {
            Description = description;
            Health = maxHealth;
            AttackSpeed = attackSpeed;
            AttackCoolDown = 0;
            Reward_XP = 1;
            Reward_Money = 1;
        }

        public static Enemy RandomEnemy()
        {
            Random rand = new Random();
            List <Enemy> enemyList = new List<Enemy>();
            enemyList.Add(new Enemy("Bunny", 5, 1, 1, 10,"A cute bunny rabbit"));
            enemyList.Add(new Enemy("Orc", 20, 5, 1, 30, "A savage orc"));
            enemyList.Add(new Enemy("Goblin", 5, 3, 2, 40, "A creepy little goblin"));
            enemyList.Add(new Enemy("Bear", 30, 5, 5, 10, "An enourmous bear"));
            enemyList.Add(new Enemy("Black Knight", 100, 1, 1, 20, "Tis but a scratch"));
            enemyList.Add(new Enemy("Dragon", 60, 8, 8, 30, "A dangerous Dragon"));
            return enemyList[rand.Next(0, enemyList.Count())];
        }
        public int GetDamage()
        {
            return Attack;
        }

        public int MakeAttack()
        {
            Random rand = new Random();
            return (rand.Next(0, 101) + Attack);
        }

        public int GetDefense()
        {
            Random rand = new Random();
            return (rand.Next(0, 101)+Defense);
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
