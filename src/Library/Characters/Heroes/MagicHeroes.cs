using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class MagicHeroes : MagicCharacter
    {
        public int VP = 0;

        protected static List<MagicHeroes> magicHeroes = new List<MagicHeroes>(); 
        
        public abstract void ReceiveAttack(Character character);
        
        public abstract void ReceiveAttack(MagicCharacter character);

        public abstract void Cure();

        public abstract void AddItem(Item item);

        public abstract void RemoveItem(Item item);

        public abstract void AddItem(MagicalItem item);

        public abstract void RemoveItem(MagicalItem item);

        public abstract void AddToEncounter();
    }
}