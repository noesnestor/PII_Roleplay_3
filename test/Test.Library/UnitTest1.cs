using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAtaque()
        {
            HeroDwarf testDwarf = new HeroDwarf("Test Dwarf");

            HeroKnight testKnight = new HeroKnight("Test Knight");

            testDwarf.ReceiveAttack(testKnight);

            int expected = 98;
            Assert.AreEqual(expected, testDwarf.Health);
        }

        [Test]
        public void TestAgregarHechizo()
        {
            SpellsBook testBook = new SpellsBook();
            testBook.AddSpell(new SpellOne());
            testBook.AddSpell(new SpellOne());

            int expected = 140;
            Assert.AreEqual(expected, testBook.AttackValue);
        }

        [Test]
        public void TestCurar()
        {
            HeroDwarf testDwarf = new HeroDwarf("Test Dwarf");

            SpellsBook testBook = new SpellsBook();
            testBook.AddSpell(new SpellOne());
            testBook.AddSpell(new SpellOne());

            HeroWizard testWizard = new HeroWizard("Test Wizard");
            testWizard.AddItem(testBook);
            
            testDwarf.ReceiveAttack(testWizard);

            testDwarf.Cure();

            int expected = 100;
            Assert.AreEqual(expected, testDwarf.Health);
        }
    }
}