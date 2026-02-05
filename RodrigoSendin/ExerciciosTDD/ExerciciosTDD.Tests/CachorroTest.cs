using System.Linq;
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

            yuri.Sexo = Sexo.Macho;
            var sexo = yuri.Sexo;

            Console.WriteLine(sexo);

            Assert.AreEqual(Sexo.Macho, sexo);
        }

        [TestMethod]
        public void Set_Get_Raca_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Raca = new Raca { Nome = "Bulldog" };
            var raca = yuri.Raca;

            Console.WriteLine(raca.Nome);

            Assert.AreEqual("Bulldog", raca.Nome);
        }

        [TestMethod]
        public void Set_Get_Porte_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.Porte = Raca.Porte.Medio;
            var porte = yuri.Porte;

            Console.WriteLine(porte);

            Assert.AreEqual(Raca.Porte.Medio, porte);
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

        [TestMethod]
        public void Cachorro_Validar_Test()
        {
            try
            {
                var sexoInvalido = (Sexo)(Enum.GetValues(typeof(Sexo)).Cast<int>().Max() + 1);

                Cachorro cachorro = new()
                {
                    Sexo = sexoInvalido,
                    DataNascimento = DateTime.Today.AddMonths(1).ToString("dd/MM/yyyy"),
                    Peso = 0
                };

                cachorro.Validar();

                Assert.Fail();
            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Inserir o nome do cachorro é obrigatório.") &&
                         ex.Message.Contains("Sexo do cachorro deve ser Macho ou Fêmea.") &&
                         ex.Message.Contains("A data de nascimento do cachorro não pode ser no futuro.") &&
                         ex.Message.Contains("O peso não pode ser menor ou igual a zero.");

                Assert.IsTrue(ok);
                Console.WriteLine(ex.Message);
            }
        }

        [TestMethod]
        public void Cachorro_Associacao_Raca_Test()
        {
            var labrador = new Raca { Nome = "Labrador" }; // Instanciou a raça

            var tequila = new Cachorro { Nome = "Tequila", Raca = labrador }; // Associou a raça ao cachorro
                                                                              // tipo dela mudou nas associações de propriedade na classe Cachorro, antes era string agora é Raca

            Console.WriteLine(tequila.Raca.Nome);

            Assert.AreEqual("Labrador", tequila.Raca.Nome);

        }

        [TestMethod]
        public void Cachorro_Associacao_Dono_Test()
        {
            var roberto = new ExerciciosTDD.Domain.Dono { Nome = "Roberto", Telefone = "18912345678", Email = "teste@emaildodono.com" };

            var liedson = new Cachorro { Nome = "Liedson", Raca = new Raca { Nome = "Vira Lata" }, Dono = roberto };

            Console.WriteLine(liedson.Dono.Nome);
            Assert.AreEqual("Roberto", liedson.Dono.Nome);
        }

        [TestMethod]
        public void Cachorro_Enum_Sexo_Test()
        {
            var teodoro = new Cachorro { Nome = "Teodoro", Sexo = Sexo.Macho };

            Console.WriteLine(teodoro.Sexo);
            Assert.AreEqual(Sexo.Macho, teodoro.Sexo);
        }

        [TestMethod]
        public void Cachorro_IPet_Test()
        {
            IPet pet = new Cachorro { Nome = "Léia", Peso = 0 };

            Assert.AreEqual("Léia", pet.Nome);
            Console.WriteLine(pet.Nome);

            var leia = pet as Cachorro; // casting para acessar a propriedade Peso. Conversão de IPet para Cachorro

            Assert.IsNotNull(leia);
            Assert.AreEqual(0, leia.Peso);
            Console.WriteLine(leia.Peso);
        }
    }
}
