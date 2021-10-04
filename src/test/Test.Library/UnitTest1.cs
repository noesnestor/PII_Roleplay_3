using NUnit.Framework;
using RoleplayGame;

namespace RoleplayGame
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
        Para hacer funcionar el Test, por razones que todavía no puedo explicar,
        tuve que agregar en el Test.Library la dirección entera del almacenamiento del archivo.
        Seguramente no funcione a menos que se modifique la dirección de referencia de
        "Test.Library.csproj". Pero entre eso o que simplemente no funcione en ningun momento,
        por lo menos prefiero que funcione aqui.
        */
        

        [Test]
        public void TestAtaque()
        {
            Dwarf testDwarf = new Dwarf("Test Dwarf");

            Knight testKnight = new Knight("Test Knight");

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
            Dwarf testDwarf = new Dwarf("Test Dwarf");

            SpellsBook testBook = new SpellsBook();
            testBook.AddSpell(new SpellOne());
            testBook.AddSpell(new SpellOne());

            Wizard testWizard = new Wizard("Test Wizard");
            testWizard.AddItem(testBook);
            
            testDwarf.ReceiveAttack(testWizard);

            testDwarf.Cure();

            int expected = 100;
            Assert.AreEqual(expected, testDwarf.Health);
        }
    }
}
