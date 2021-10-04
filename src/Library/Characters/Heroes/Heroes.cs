using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Heroes : Character
    {
        protected static List<Heroes> heroes = new List<Heroes>();
        
        public int VP = 0;
        
        public abstract void ReceiveAttack(Character character);

        public abstract void ReceiveAttack(MagicCharacter character);

        public abstract void Cure();

        public abstract void AddItem(Item item);

        public abstract void RemoveItem(Item item);

        public abstract void AddToEncounter();
    }
}
