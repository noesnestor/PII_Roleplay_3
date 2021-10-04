using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            MagicHeroes gandalf = new HeroWizard("Gandalf");
            gandalf.AddItem(book);

            Enemies gimli = new EnemyDwarf("Gimli");

            gimli.AddToEncounter();
            gandalf.AddToEncounter();

            Console.WriteLine($"Gimli has {gimli.Health} HP.");
            Console.WriteLine($"Gandalf attacks Gimli with {gandalf.AttackValue} Atk.");

            gimli.ReceiveAttack(gandalf);

            Console.WriteLine($"Gimli has {gimli.Health} HP.");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has {gimli.Health} HP!");
        }
    }
}
