using System.Collections.Generic;

namespace RoleplayGame
{
    public abstract class Character
    {
        protected int health = 100;

        protected List<Item> items = new List<Item>();

        public string Name { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item is AttackItem)
                    {
                        value += (item as AttackItem).AttackValue;
                    }
                }
                foreach (Item item in this.items)
                {
                    if (item is Atk_DefItem)
                    {
                        value += (item as Atk_DefItem).AttackValue;
                    }
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Item item in this.items)
                {
                    if (item is DefenseItem)
                    {
                        value += (item as DefenseItem).DefenseValue;
                    }
                }
                foreach (Item item in this.items)
                {
                    if (item is Atk_DefItem)
                    {
                        value += (item as Atk_DefItem).DefenseValue;
                    }
                }
                return value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            protected set
            {
                this.health = value < 0 ? 0 : value;
            }
        }   
        public abstract void ReceiveAttack(Character character);

        public abstract void ReceiveAttack(MagicCharacter character);

        public abstract void Cure();

        public abstract void AddItem(Item item);

        public abstract void RemoveItem(Item item);
    }
}
    