namespace RoleplayGame
{
    public abstract class Enemies : Character
    {
        public int VP = 5;

        public abstract void ReceiveAttack(Character character);

        public abstract void ReceiveAttack(MagicCharacter character);

        public abstract void Cure();

        public abstract void AddItem(Item item);

        public abstract void RemoveItem(Item item);
    }
}