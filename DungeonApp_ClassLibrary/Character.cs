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
                if (value > MaxHealth) { _health = MaxHealth; }
                else { _health = value; }
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
            AttackCoolDown = 0;
            IsAlive = true;
        }

        public virtual string ToString()
        {
            return  Name;
        }
    }
}