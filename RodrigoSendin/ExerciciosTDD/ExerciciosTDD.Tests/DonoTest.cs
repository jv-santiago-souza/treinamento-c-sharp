using ExerciciosTDD.Domain;

namespace ExerciciosTDD.Tests
{
    [TestClass]
    public class DonoTest
    {
        [TestMethod]
        public void AddPet_Test()
        {
            var lucio = new Cachorro { Nome = "Lúcio" };
            var amendobobo = new Cachorro { Nome = "Amendobobo" };

            var lucindo = new Dono { Nome = "Lucindo" };

            // lucindo.Pets = new List<Cachorro>(); // Precisa ser inicializado antes de adicionar itens à coleção

            // PRECISA ter atribuição, caso contrário o campo Dono fica null
            //lucio.Dono = lucindo;
            //lucindo.Pets.Add(lucio);
            //amendobobo.Dono = lucindo;
            //lucindo.Pets.Add(amendobobo);

            lucindo.AddPet(lucio);
            lucindo.AddPet(amendobobo);

            Assert.HasCount(2, lucindo.Pets);

            foreach (var pet in lucindo.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");

            // Verificações sobre dono
            Assert.AreEqual(lucindo, lucio.Dono);
            Assert.AreEqual(lucindo, amendobobo.Dono);
        }

        [TestMethod]
        public void RemovePet_Test()
        {
            var lucio = new Cachorro { Nome = "Lúcio" };
            var amendobobo = new Cachorro { Nome = "Amendobobo" };

            var lucindo = new Dono { Nome = "Lucindo" };

            lucindo.AddPet(lucio);
            lucindo.AddPet(amendobobo);

            lucindo.RemovePet(lucio);

            Assert.HasCount(1, lucindo.Pets);

            foreach (var pet in lucindo.Pets)
                Console.WriteLine(pet.Nome);

            // Verificações sobre dono
            Assert.IsNull(lucio.Dono);
            Assert.AreEqual(lucindo, amendobobo.Dono);
        }

        [TestMethod]
        public void AddPets_Test()
        {
            var lucio = new Cachorro { Nome = "Lúcio" };
            var amendobobo = new Cachorro { Nome = "Amendobobo" };

            var lucindo = new Dono { Nome = "Lucindo" };

            var pets = new[] { lucio, amendobobo };

            //lucindo.AddPet(pets);
            lucindo.AddPet(lucio, amendobobo); // direto, sem passar array, graças ao params na classe

            Assert.HasCount(2, lucindo.Pets);

            foreach (var pet in lucindo.Pets)
                Console.WriteLine($"{pet.GetTipo()}: {pet.Nome}");

            // Verificações sobre dono
            Assert.AreEqual(lucindo, lucio.Dono);
            Assert.AreEqual(lucindo, amendobobo.Dono);
        }

        [TestMethod]
        public void RemovePets_Test()
        {
            var lucio = new Cachorro { Nome = "Lúcio" };
            var amendobobo = new Cachorro { Nome = "Amendobobo" };

            var lucindo = new Dono { Nome = "Lucindo" };

            lucindo.AddPet(lucio);
            lucindo.AddPet(amendobobo);

            var pets = new[] { lucio, amendobobo };

            lucindo.RemovePet(pets);

            Assert.HasCount(0, lucindo.Pets);

            Assert.IsNull(lucio.Dono);
            Assert.IsNull(amendobobo.Dono);
        }
    }
}
