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
            var latido = belinha.Latir(5);

            Console.WriteLine(latido);

            Assert.AreEqual("Au! Au! Au! Au! Au! ", latido);
        }

        [TestMethod]
        public void Belinha_QuantoDevoComer_Test()
        {
            Cachorro belinha = new Cachorro();
            var quantoDevoComer = belinha.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("como tenho 1kg, devo comer 50g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            var quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("como tenho 15kg, devo comer 750g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            var quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);
        }

        [TestMethod]
        public void Set_Get_Nome_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Nome = "Yuri";
            var nome = yuri.Nome;

            Console.WriteLine(nome);

            Assert.AreEqual("Yuri", nome);
        }

        [TestMethod]
        public void Set_Get_Sexo_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Sexo = "Macho";
            var sexo = yuri.Sexo;

            Console.WriteLine(sexo);

            Assert.AreEqual("Macho", sexo);
        }

        [TestMethod]
        public void Set_Get_Raca_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Raca = "Bulldog";
            var raca = yuri.Raca;

            Console.WriteLine(raca);

            Assert.AreEqual("Bulldog", raca);
        }

        [TestMethod]
        public void Set_Get_Porte_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Porte = "Médio";
            var porte = yuri.Porte;

            Console.WriteLine(porte);

            Assert.AreEqual("Médio", porte);
        }

        //[TestMethod]
        //public void Set_Get_Idade_Test()
        //{
        //    Cachorro yuri = new Cachorro();

        //    yuri.setIdade(2);
        //    var idade = yuri.getIdade();

        //    Console.WriteLine(idade);

        //    Assert.AreEqual(2, idade);
        //}

        [TestMethod]
        public void Set_Get_DataNascimento_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.DataNascimento = "";
            var idade = yuri.DataNascimento;
        }

        [TestMethod]
        public void Set_Get_Peso_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setPeso(15);
            var peso = yuri.getPeso();

            Console.WriteLine(peso);

            Assert.AreEqual(15, peso);
        }

        [TestMethod]
        public void Set_Get_Vacinado_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.setVacinado(true);
            var vacinado = yuri.getVacinado();

            Console.WriteLine(vacinado);

            Assert.IsTrue(vacinado);
        }

        [TestMethod]
        public void Set_Get_DataNascimento_Test2()
        {
            Cachorro yuri = new Cachorro();
            var idade = Cachorro.IdadeCachorro("04/12/2025");

            Console.WriteLine(idade);
        }
    }
}
