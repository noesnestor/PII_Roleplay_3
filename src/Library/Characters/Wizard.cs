using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard: MagicCharacter
        {
        public Wizard(string name)
        {
            this.Name = name;
            
            this.AddItem(new Staff());
        }

        public override void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public override void Cure()
        {
            this.Health = 100;
        }

        public override void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public override void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }
        public override void AddItem(IMagicalItem item)
        {
            this.magicalItems.Add(item);
        }

        public override void RemoveItem(IMagicalItem item)
        {
            this.magicalItems.Remove(item);
        }
    }
}