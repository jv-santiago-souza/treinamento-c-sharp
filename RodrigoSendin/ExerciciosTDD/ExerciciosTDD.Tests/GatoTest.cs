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
        public void Validar_Test()
        {
            try
            {
                var sexoInvalido = (Sexo)(Enum.GetValues(typeof(Sexo)).Cast<int>().Max() + 1);

                Gato gato= new()
                {
                    Sexo = sexoInvalido,
                };

                gato.Validar();

                Assert.Fail();
            }
            catch (Exception ex)
            {
                var ok = ex.Message.Contains("Inserir o nome do gato é obrigatório.") &&
                         ex.Message.Contains("Sexo do gato deve ser Macho ou Fêmea.");

                Assert.IsTrue(ok);
                Console.WriteLine(ex.Message);
            }
        }
    }
}
