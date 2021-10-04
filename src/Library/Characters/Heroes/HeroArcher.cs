using System.Collections.Generic;
namespace RoleplayGame
{
    public class HeroArcher: Heroes
    {
        public HeroArcher(string name)
        {
            this.Name = name;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }
        
        public override void ReceiveAttack(Character character)
        {
            if (this.DefenseValue < character.AttackValue)
            {
                this.Health -= character.AttackValue - this.DefenseValue;
            }
        }

        public override void ReceiveAttack(MagicCharacter character)
        {
            if (this.DefenseValue < character.AttackValue)
            {
                this.Health -= character.AttackValue - this.DefenseValue;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }

        public override void AddItem(Item item)
        {
            this.items.Add(item);
        }

        public override void RemoveItem(Item item)
        {
            this.items.Remove(item);
        }
        public override void AddToEncounter()
        {
            Heroes.heroes.Add(this);
        }
    }
}