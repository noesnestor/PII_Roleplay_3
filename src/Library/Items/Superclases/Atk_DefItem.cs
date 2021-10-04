namespace RoleplayGame
{
    public abstract class Atk_DefItem: Item
    {
        public abstract int AttackValue {get; }
        
        public abstract int DefenseValue { get; } 
    }
}