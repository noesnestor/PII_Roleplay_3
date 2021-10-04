using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Enemies : Character
    {
        protected static List<Enemies> enemies = new List<Enemies>();
        
        public int VP = 5;

        public abstract void ReceiveAttack(Character character);

        public abstract void ReceiveAttack(MagicCharacter character);

        public abstract void Cure();

        public abstract void AddItem(Item item);

        public abstract void RemoveItem(Item item);
        
        public abstract void AddToEncounter();
    }
}