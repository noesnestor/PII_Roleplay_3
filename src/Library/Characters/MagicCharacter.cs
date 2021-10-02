using System.Collections.Generic;

namespace RoleplayGame
{
public abstract class MagicCharacter: IMagicCharacter
{
    protected int health = 100;

    protected List<IItem> items = new List<IItem>();

    protected List<IMagicalItem> magicalItems = new List<IMagicalItem>();

    public string Name { get; set; }
    
    public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalAttackItem)
                    {
                        value += (item as IMagicalAttackItem).AttackValue;
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
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                foreach (IMagicalItem item in this.magicalItems)
                {
                    if (item is IMagicalDefenseItem)
                    {
                        value += (item as IMagicalDefenseItem).DefenseValue;
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
    public abstract void ReceiveAttack(int power);

    public abstract void Cure();

    public abstract void AddItem(IItem item);

    public abstract void RemoveItem(IItem item);

    public abstract void AddItem(IMagicalItem item);

    public abstract void RemoveItem(IMagicalItem item);
    }
}
