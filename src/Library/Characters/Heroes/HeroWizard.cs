using System.Collections.Generic;
namespace RoleplayGame
{
    public class HeroWizard: MagicHeroes
        {
        public HeroWizard(string name)
        {
            this.Name = name;
            this.AddItem(new Staff());
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
        public override void AddItem(MagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public override void RemoveItem(MagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
        public override void AddToEncounter()
        {
            MagicHeroes.magicHeroes.Add(this);
        }
    }
}