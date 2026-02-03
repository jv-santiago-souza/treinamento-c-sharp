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
    }
}
