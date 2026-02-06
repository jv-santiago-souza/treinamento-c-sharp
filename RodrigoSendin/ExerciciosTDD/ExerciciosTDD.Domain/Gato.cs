using System.Text;
using static ExerciciosTDD.Domain.Especie;

namespace ExerciciosTDD.Domain
{
    public class Gato : Animal, IPet
    {
        protected override EspecieAnimal Especie => EspecieAnimal.Gato;

        public string Miar(short qtdeMiados)
        {
            if (qtdeMiados <= 0) return string.Empty;

            var latido = "Meaw! ";
            var builder = new StringBuilder();

            for (var i = 0; i < qtdeMiados; i++)
            {
                builder.Append(latido);
            }

            return builder.ToString();
        }

        public override string QuantoDevoComer()
        {
            return $"como tenho {Peso}kg, devo comer {Peso * 50}g por dia";
        }
        protected override void ValidarEspecifico(List<string> erros) { }
    }
}
