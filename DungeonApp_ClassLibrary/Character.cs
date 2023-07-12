namespace DungeonApp_ClassLibrary
{
    public class Character
    {
        private int _health;

        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public bool IsAlive { get; set; }
        public int AttackCoolDown { get; set; }
        public int Health
        {
            get { return _health; }
            set
            {
                if (Health > MaxHealth) { _health = MaxHealth; }
                else { _health = Health; }
            }
        }
        public Character()
        {
            Name = "";
            MaxHealth = 1;
            Health = MaxHealth;
            Attack = 1;
            Defense = 1;
        }

        public Character(string name, int maxHealth, int attack, int defense)
        {
            Name = name;
            MaxHealth = maxHealth;
            Attack = attack;
            Defense = defense;
            Health = maxHealth;
            AttackCoolDown = 0;
        }

        public virtual string ToString()
        {
            return  Name;
        }
    }
}