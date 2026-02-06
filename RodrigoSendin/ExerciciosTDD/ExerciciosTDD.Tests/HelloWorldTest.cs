using System;
using ExerciciosTDD.Domain;

namespace ExerciciosTDD.Tests
{
    [TestClass]
    public sealed class HelloWorldTest
    {
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
                MinhaClasse obj = null;
                // obj.OutroMetodo();

                if(obj == null)
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
    }
}
 