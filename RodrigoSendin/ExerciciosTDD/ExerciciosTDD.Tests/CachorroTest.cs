using ExerciciosTDD.Domain;

namespace ExerciciosTDD.Tests
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Latir_Test()
        {
            Cachorro belinha = new Cachorro();
            string latido = belinha.Latir();

            Console.WriteLine(latido);

            Assert.AreEqual("Au Au!", latido);
        }

        [TestMethod]
        public void Belinha_QuantoDevoComer_Test()
        {
            Cachorro belinha = new Cachorro();
            string quantoDevoComer = belinha.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }
    }
}
