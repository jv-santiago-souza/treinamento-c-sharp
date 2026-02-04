using System;
using ExerciciosTDD.Domain;

namespace ExerciciosTDD.Tests
{
    [TestClass]
    public sealed class HelloWorldTest{
        [TestMethod]
        public void SayHello_Test(){
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
    }
}
