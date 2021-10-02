using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: Character
    {
        public Dwarf(string name)
        {
            this.Name = name;
            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
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
    }
}