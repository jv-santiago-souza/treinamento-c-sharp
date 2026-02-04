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
            Cachorro cachorro1 = new Cachorro();
            cachorro1.setNome("Rex");

            Cachorro cachorro2 = new Cachorro();
            cachorro2.setNome("Rex");

            Assert.AreEqual(cachorro1.getNome(), cachorro2.getNome());
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

    }
}
