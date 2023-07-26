using Xunit;
using DungeonApp_ClassLibrary;
using DungeonApp_Interfaces;
using DungeonApp_MethodLibrary;

namespace DungeonApp_Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CombatTurnTest()
        {
            Player testPlayer = new Player("test", Races.Human, Weapon.WeaponList(1));
            Enemy testEnemy = new Enemy("Test Dummy", 1, 1, 1, 1, "A simple trainging dummy");
            bool playerAttack = false;
            bool enemyAttack = false;

            while (!playerAttack || !enemyAttack)
            {
                if (testPlayer.AttackReady()) { playerAttack = true; }
                if (testEnemy.AttackReady()) { enemyAttack = true; }
            }

            Assert.True(playerAttack);
        }
        [Fact]
        public void RaceModifier()
        {
            Player testPlayer = new Player("Test", Races.Dwarf, Weapon.WeaponList(1));

            int expectedAttack = 7;

            Assert.Equal(expectedAttack, testPlayer.Attack);
        }
        [Fact]
        public void TestDeath()
        {
            Player testPlayer = new Player("Test", Races.Dwarf, Weapon.WeaponList(1));
            testPlayer.TakeDamage(10);

            Assert.False(testPlayer.IsAlive);
        }
        [Fact]
        public void TestHeal()
        {
            Player testPlayer = new Player("Test", Races.Dwarf, Weapon.WeaponList(1));

            testPlayer.Health += 70;

            Assert.Equal(testPlayer.MaxHealth, testPlayer.Health);
        }
        [Fact]
        public void TestLevelUp()
        {
            Player testPlayer = new Player("Test", Races.Dwarf, Weapon.WeaponList(1));

            for(int i = 0; i < 110; i++)
            {
                testPlayer.GetXP(1);
            }

            Assert.Equal(5, testPlayer.Level);
        }
    }
}