using System.Linq;
using System.IO;
using ExerciciosTDD.Domain;
using System.Runtime.InteropServices;

namespace ExerciciosTDD.Tests
{
    [TestClass]
    public sealed class HelloWorldTest
    {
        private static List<IPet> _pets;

        [ClassInitialize]
        public static void Setup(TestContext context)
        {
            _pets = HelloWorld.Ler_Pets_Do_Arquivo("C:\\TesteAula030\\Outra Pasta\\pets.csv");
        }
        private static void ImprimePets(IEnumerable<IPet> pets)
        {
            foreach (var pet in pets)
                Console.WriteLine($"[{pet.GetTipo()}] {pet.Nome} - {pet.Dono}");
        }

        [TestMethod]
        public void SayHello_Test()
        {
            string mensagem = HelloWorld.SayHello();

            Assert.AreEqual("Hello, World!", mensagem);
        }

        [TestMethod]
        public void Igualdade_Entre_Atributos_De_Complexos_Test()
        {
            // Uso em tipos complexos

            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Rex";

            Cachorro cachorro2 = new Cachorro();
            cachorro2.Nome = "Rex";

            Assert.AreEqual(cachorro1.Nome, cachorro2.Nome); // Retorna válido; compara o conteúdo dos atributos
            // Assert.AreEqual(cachorro1, cachorro2); // Retorna inválido; compara referências não o conteúdo

            // Comparação em tipos primitivos

            var num1 = 4;
            var num2 = 4;

            Assert.AreEqual(num1, num2); // Retorna válido; tipos primitivos comparam valores
        }

        //[TestMethod]
        //public void Desigualdade_Entre_Tipos_de_Referencia_Test()
        //{
        //    Cachorro cachorro1 = new Cachorro();
        //    cachorro1.setNome("Rex");

        //    Cachorro cachorro2 = new Cachorro();
        //    cachorro2.setNome("Rex");

        //    Assert.AreEqual(cachorro1, cachorro2);
        //}

        [TestMethod]
        public void MinhaClasse_Test()
        {
            var obj = new MinhaClasse();
        }

        [TestMethod]
        public void DateTime_Test()
        {
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            var agora = DateTime.Now;
            Console.WriteLine(agora);
        }

        [TestMethod]
        public void DateTime_Desmembrando_Test()
        {
            var agora = DateTime.Now;

            Console.WriteLine(agora);
            Console.WriteLine(agora.Year);
            Console.WriteLine(agora.Month);
            Console.WriteLine(agora.Day);
            Console.WriteLine(agora.Hour);
            Console.WriteLine(agora.Minute);
            Console.WriteLine(agora.Second);
            Console.WriteLine(agora.Millisecond);
            Console.WriteLine(agora.DayOfWeek);
            Console.WriteLine(agora.DayOfYear);
        }

        [TestMethod]
        public void DateTime_Add_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);

            var mais5horas = agora.AddHours(5);
            Console.WriteLine(mais5horas);
            Console.WriteLine(mais5horas.GetType());

            var amanha = agora.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = agora.AddDays(-1);
            Console.WriteLine(ontem);
        }

        [TestMethod]
        public void DateTime_Inicializacao_Test()
        {
            var data = new DateTime(2007, 06, 01); // Ano, Mês, Dia
            Console.WriteLine(data);

            var dataComHora = new DateTime(2007, 06, 01, 18, 33, 0);
            Console.WriteLine(dataComHora);
        }

        [TestMethod]
        public void DateTime_Convertendo_String_Test()
        {
            var data = DateTime.Parse("2024-06-15 14:30:00");
        }

        [TestMethod]
        public void DateTime_Quantidade_Dias_No_Mes_Test()
        {
            var diasFev2024 = DateTime.DaysInMonth(2024, 2);
            Console.WriteLine(diasFev2024);
            var diasFev2023 = DateTime.DaysInMonth(2023, 2);
            Console.WriteLine(diasFev2023);

            var ultimoDiaFev2024 = new DateTime(2024, 2, diasFev2024);
        }

        [TestMethod]
        public void DateTime_Formatacoes_Test()
        {
            var agora = DateTime.Now;
            Console.WriteLine(agora);
            Console.WriteLine(agora.ToString("d"));
            Console.WriteLine(agora.ToString("G"));
            Console.WriteLine(agora.ToString("f"));

            Console.WriteLine(agora.ToString("dd/MM/yyyy"));
            Console.WriteLine(agora.ToString("dd/MM/yyyy HH:mm"));

            Console.WriteLine(agora.ToString("MMMM"));
        }

        [TestMethod]
        public void TimeSpan_Test()
        {
            var hoje = DateTime.Now;
            var amanha = hoje.AddDays(1);

            var dif = amanha - hoje; // operador de subtração entre DateTimes resulta em TimeSpan
            Console.WriteLine(dif);
            var diferenca = amanha.Subtract(hoje); // método Subtract entre DateTimes resulta em TimeSpan (mesma coisa que o operador acima)
            Console.WriteLine(diferenca);

            Console.WriteLine(dif.TotalSeconds);
            Console.WriteLine(dif.TotalHours);
        }

        [TestMethod]
        public void Array_While_Test()
        {
            var array = new int[3];
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;

            var i = 0;
            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
            }
        }

        [TestMethod]
        public void Array_Do_While_Test()
        {
            var array = new string[] { "Eu", "Tu", "Nós" };

            var i = 0;
            do
            {
                Console.WriteLine(array[i]);
                i++;
            } while (i < array.Length);
        }

        [TestMethod]
        public void Array_For_Test()
        {
            var array = new[] { 1.1, 2.2, 3.3, 4.4 };

            for (var i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }

        [TestMethod]
        public void Array_For_Invertido_Test()
        {
            var array = new[] { 1.1, 2.2, 3.3, 4.4 };

            for (var i = array.Length - 1; i >= 0; i--)
                Console.WriteLine(array[i]);
        }

        [TestMethod]
        public void Array_Foreach_Test()
        {
            var array = new[] { 1.1, 2.2, 3.3, 4.4 };

            var lista = new List<string> { "A", "B", "C" };

            foreach (var item in array)
                Console.WriteLine(item);
        }

        [TestMethod]
        public void Exception_Test()
        {
            try
            {
                MinhaClasse obj = null!;
                // obj.OutroMetodo();

                if (obj == null)
                {
                    throw new Exception("O objeto não foi instanciado"); // Força a exceção
                }

                var x = 10;
                var y = 0;

                var resultado = x / y;
                Console.WriteLine(resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ocorreu um erro ao tentar dividir por zero!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Mensagem enviado pela finally. Aparece mesmo que ocorra uma Exception");
            }
        }

        [TestMethod]
        public void Classe_Abstrata_Test()
        {
            // var animal = new Animal(); // Não é possível instanciar uma classe abstrata

        }

        [TestMethod]
        public void SystemIO_CreateDirectory_Test()
        {
            Directory.CreateDirectory("C:\\TesteAula030");
            Directory.CreateDirectory("C:\\TesteAula030\\Outra Pasta");
        }

        //[TestMethod]
        //public void SystemIO_CreateFile_Txt_Test()
        //{
        //    File.WriteAllText("C:\\TesteAula030\\Outra Pasta\\Hello.txt", "Cogumelo cabeçudo");
        //}

        [TestMethod]
        public void SystemIO_GetFileSystemEntries_Test()
        {
            var lista = Directory.GetFileSystemEntries("C:\\TesteAula030\\Outra Pasta");

            foreach (var item in lista) Console.WriteLine(item);
        }

        [TestMethod]
        public void SystemIO_File_Read_Txt_Test()
        {
            var conteudo = File.ReadAllText("C:\\TesteAula030\\Outra Pasta\\Hello.txt");
            Console.WriteLine(conteudo);
        }

        [TestMethod]
        public void SystemIO_Ler_Pets_Do_Arquivo()
        {
            string caminho = "C:\\TesteAula030\\Outra Pasta\\pets.csv";

            List<IPet> listaDePets = HelloWorld.Ler_Pets_Do_Arquivo(caminho);

            Console.WriteLine("Listagem dos pets");
            Console.WriteLine($"Total de pets encontrados: {listaDePets.Count}");

            foreach (IPet pet in listaDePets)
            {
                Animal animal = (Animal)pet;

                Console.WriteLine($"\nPET: {animal.Nome}");
                Console.WriteLine($"Espécie: {animal.GetType().Name}");
                Console.WriteLine($"Sexo: {animal.Sexo}");
                Console.WriteLine($"Peso: {animal.Peso}kg");
                Console.WriteLine($"Dono: {animal.Dono.Nome}");


                if (pet is Cachorro cachorro)
                {
                    Console.WriteLine($"Data de Nascimento: {cachorro.DataNascimento.ToShortDateString()}");

                    string statusVacina = cachorro.getVacinado() ? "Sim" : "Não";
                    Console.WriteLine($"Vacinado: {statusVacina}");
                }
                else if (pet is Gato gato)
                {
                    Console.WriteLine($"- Miou: {gato.Miar(1)}");
                }

                Console.WriteLine("-------------------------------------------");
            }

            Assert.IsNotEmpty(listaDePets, "A lista não deveria estar vazia!");
        }

        [TestMethod]
        public void Linq_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Gato"
                        select pet;

            ImprimePets(query);
        }

        [TestMethod]
        public void Linq_Metodo_Test()
        {
            var query = _pets.Where(pet => pet.GetTipo() == "Gato");
        }

        [TestMethod]
        public void Linq_Order_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Gato"
                        orderby pet.Nome
                        select pet;

            ImprimePets(query);
        }

        [TestMethod]
        public void Linq_Order_Metodo_Test()
        {
            var query = _pets.Where(pet => pet.GetTipo() == "Gato")
                              .OrderByDescending(pet => pet.Nome);
            ImprimePets(query);
        }

        [TestMethod]
        public void Linq_Projecao_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Gato"
                        orderby pet.Peso
                        select new { Nome = pet.Nome, Peso = pet.Peso };

            foreach (var pet in query)
                Console.WriteLine($"{pet.Nome} - {pet.Peso}kg");
        }

        [TestMethod]
        public void Linq_Projecao_Metodo_Test()
        {
            var query = _pets.Where(pet => pet.GetTipo() == "Cachorro")
                              .OrderByDescending(pet => pet.Peso).
                              Select(pet => new { pet.Nome, pet.Peso });

            foreach (var pet in query)
                Console.WriteLine($"{pet.Nome} - {pet.Peso}kg");
        }

        [TestMethod]
        public void Linq_Skip_Take_Test()
        {
            var query = (from pet in _pets
                         where pet.GetTipo() == "Gato"
                         orderby pet.Peso
                         select new { Nome = pet.Nome, Peso = pet.Peso }).Skip(3).Take(3);

            foreach (var pet in query)
                Console.WriteLine($"{pet.Nome} - {pet.Peso}kg");
        }

        [TestMethod]
        public void Linq_First_Last_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Gato"
                        orderby pet.Peso
                        select new { Nome = pet.Nome, Peso = pet.Peso };

            var primeiro = query.FirstOrDefault();
            var ultimo = query.FirstOrDefault();

            Console.WriteLine(primeiro.Nome);
            Console.WriteLine(ultimo.Nome);
        }

        [TestMethod]
        public void Linq_Agregacoes_Test()
        {
            var query = from pet in _pets
                        where pet.GetTipo() == "Gato"
                        orderby pet.Peso
                        select new { Nome = pet.Nome, Peso = pet.Peso };

            var somaPesosTotal = query.Sum(pet => pet.Peso);
            Console.WriteLine(somaPesosTotal);
            var maiorValor = query.Max(pet => pet.Peso);
            Console.WriteLine(maiorValor);
            var MenorValor = query.Min(pet => pet.Peso);
            Console.WriteLine(MenorValor);
            var media = query.Average(pet => pet.Peso);
            Console.WriteLine(media);
        }

        [TestMethod]
        public void Linq_Group_Test()
        {
            var query = from pet in _pets
                        group pet by pet.Sexo into g
                        select new { Sexo = g.Key, Total = g.Count() };

            foreach (var pet in query)
                Console.WriteLine($"{pet.Sexo} - {pet.Total}");
        }

        [TestMethod]
        public void Linq_Query_Exercicio_Test()
        {
            var query = from pet in _pets
                        group pet by pet.Dono.Nome into g
                        orderby g.Key
                        select new { NomeDono = g.Key, Total = g.Count() };

            var queryCachorro = from pet in _pets
                        where pet.GetTipo() == "Cachorro"
                        select new { Nome = pet.Nome, Sexo = pet.Sexo };

            var maisVelho = queryCachorro.FirstOrDefault().Nome;
            var maisNovo = queryCachorro.LastOrDefault().Nome;


            foreach (var item in query)
                Console.WriteLine($"{item.NomeDono} possui {item.Total} animal(is) em sua tutela.");

            Console.WriteLine($"O cachorro mais velho é o(a) {maisVelho}");
            Console.WriteLine($"O cachorro mais novo é o(a) {maisNovo}");
        }

        [TestMethod]
        public void Async_Await_Tarefa_Test()
        {
            var retorno1 = HelloWorld.Tarefa("Um", 5);
            Console.WriteLine(retorno1);

            var retorno2 = HelloWorld.Tarefa("Dois", 3);
            Console.WriteLine(retorno2);
        }

        [TestMethod]
        public async Task Async_Await_Tarefa_1_Test()
        {
            Task<string> tarefa1 = HelloWorld.TarefaAsync("Um", 5);
            // Console.WriteLine(tarefa1);

            Task<string> tarefa2 = HelloWorld.TarefaAsync("Dois", 3);
            // Console.WriteLine(tarefa2);

            Console.WriteLine("Código que pode ser executado de maneira independente ao retorno da tarefa");

            string resultado = await tarefa1;

            Console.WriteLine(resultado);
        }

        [TestMethod]
        public async Task Async_Await_Tarefa_2_Test()
        {
            Task<string> tarefa1 = HelloWorld.TarefaAsync("Um", 5);
            Task<string> tarefa2 = HelloWorld.TarefaAsync("Dois", 3);

            string resultado1 = await tarefa1;
            Console.WriteLine(resultado1);

            string resultado2 = await tarefa2;
            Console.WriteLine(resultado2);
        }

        [TestMethod]
        public async Task Async_Await_Tarefa_3_Test()
        {
            Task<string> tarefa1 = HelloWorld.TarefaAsync("Um", 5);
            Task<string> tarefa2 = HelloWorld.TarefaAsync("Dois", 3);

            string resultado1 = await tarefa1;
            Console.WriteLine(resultado1);

            Task<string> tarefa3 = HelloWorld.TarefaAsync("Três", 5);

            string resultado2 = await tarefa2;
            Console.WriteLine(resultado2);

            string resultado3 = await tarefa3;
            Console.WriteLine(resultado3);
        }
    }
}
 