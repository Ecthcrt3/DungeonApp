namespace DungeonApp_Interfaces
{
    public interface ICombatable
    {
        int MakeAttack();
        bool AttackReady();
        int GetDefense();
        int GetDamage();
        void TakeDamage(int dmg);
    }
}