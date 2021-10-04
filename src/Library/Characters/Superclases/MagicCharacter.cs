using System.Collections.Generic;

namespace RoleplayGame
{
public abstract class MagicCharacter
{
    protected int health = 100;

    protected List<Item> items = new List<Item>();

    protected List<MagicalItem> magicalItems = new List<MagicalItem>();

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
                foreach (MagicalItem item in this.magicalItems)
                {
                    if (item is MagicalAttackItem)
                    {
                        value += (item as MagicalAttackItem).AttackValue;
                    }
                }
                foreach (MagicalItem item in this.magicalItems)
                {
                    if (item is MagicalAtk_DefItem)
                    {
                        value += (item as MagicalAtk_DefItem).AttackValue;
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
                foreach (MagicalItem item in this.magicalItems)
                {
                    if (item is MagicalDefenseItem)
                    {
                        value += (item as MagicalDefenseItem).DefenseValue;
                    }
                }
                foreach (MagicalItem item in this.magicalItems)
                {
                    if (item is MagicalAtk_DefItem)
                    {
                        value += (item as MagicalAtk_DefItem).DefenseValue;
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

    public abstract void AddItem(MagicalItem item);

    public abstract void RemoveItem(MagicalItem item);
    }
}
