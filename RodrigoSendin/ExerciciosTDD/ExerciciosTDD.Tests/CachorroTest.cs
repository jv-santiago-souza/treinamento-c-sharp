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

        [TestMethod]
        public void Set_Get_Nome_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setNome("Yuri");
            string nome = yuri.getNome();

            Console.WriteLine(nome);

            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]
        public void Set_Get_Sexo_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setSexo("Macho");
            string sexo = yuri.getSexo();

            Console.WriteLine(sexo);

            Assert.AreEqual("Macho", sexo);
        }

        [TestMethod]
        public void Set_Get_Raca_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setRaca("Bulldog");
            string raca = yuri.getRaca();

            Console.WriteLine(raca);

            Assert.AreEqual("Bulldog", raca);
        }

        [TestMethod]
        public void Set_Get_Porte_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setPorte("Médio");
            string porte = yuri.getPorte();

            Console.WriteLine(porte);

            Assert.AreEqual("Médio", porte);
        }

        [TestMethod]
        public void Set_Get_Idade_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setIdade(2);
            int idade = yuri.getIdade();

            Console.WriteLine(idade);

            Assert.AreEqual(2, idade);
        }

        [TestMethod]
        public void Set_Get_Peso_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setPeso(15);
            double peso = yuri.getPeso();

            Console.WriteLine(peso);

            Assert.AreEqual(15, peso);
        }
    }
}
