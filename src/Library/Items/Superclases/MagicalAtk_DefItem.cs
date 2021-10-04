namespace RoleplayGame
{
    public abstract class MagicalAtk_DefItem: MagicalItem
    {
        public abstract int AttackValue {get; }
        
        public abstract int DefenseValue { get; } 
    }
}