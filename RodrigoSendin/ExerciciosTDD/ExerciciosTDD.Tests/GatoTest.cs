using ExerciciosTDD.Domain;

namespace ExerciciosTDD.Tests
{
    [TestClass]
    public class GatoTest
    {
        [TestMethod]
        public void Miar_Test()
        {
            Gato flor = new Gato();
            var miados = flor.Miar(5);

            Console.WriteLine(miados);

            Assert.AreEqual("Meaw! Meaw! Meaw! Meaw! Meaw! ", miados);
        }

        [TestMethod]
        public void Validar_Gato_DeveRetornarTodosOsErros()
        {
            var gato = new Gato
            {
                Nome = " ",
                Sexo = (Sexo)99,
                Peso = -1
            };

            var ex = Assert.Throws<Exception>(() => gato.Validar());

            Assert.Contains("O nome do gato é obrigatório.", ex.Message);
            Assert.Contains("O sexo do animal gato deve ser Macho ou Fêmea", ex.Message);
            Assert.Contains("Peso deve ser maior que zero.", ex.Message);
        }
    }
}
