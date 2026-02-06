using static ExerciciosTDD.Domain.Especie;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExerciciosTDD.Domain
{
    public abstract class Animal
    {
        public string Nome { get; set; } = string.Empty;
        public Sexo Sexo { get; set; }
        public string Foto { get; set; } = string.Empty;
        public Dono Dono { get; set; } = null!;
        public double Peso { get; set; }

        protected abstract EspecieAnimal Especie { get; } // ENUM

        public abstract string QuantoDevoComer(); // Quem herdar de animal, obrigatoriamente tem que implementar o método QuantoDevoComer, pois é abstrato

        // abstract serve para obrigar as classes filhas a implementarem o método, ou seja, não tem implementação na classe pai, só na filha
        // Já o virtual tem uma implementação na classe pai, mas pode ser sobrescrito (override) nas classes filhas.

        public void Validar()
        {
            var mensagens = new List<string>();

            // Regras comuns a todos os animais
            if (string.IsNullOrWhiteSpace(Nome)) mensagens.Add($"O nome do {Especie.ToString().ToLower()} é obrigatório.");
            if (Peso <= 0) mensagens.Add("Peso deve ser maior que zero.");
            if (Sexo != Sexo.Macho && Sexo != Sexo.Femea) mensagens.Add($"O sexo do animal {Especie.ToString().ToLower()} deve ser Macho ou Fêmea");

            ValidarEspecifico(mensagens);

            var ex = Helpers.ConvertStringListToException(mensagens);

            if (ex != null)
                throw ex; 
        }

        // Cada filha é obrigada a implementar sua regra extra
        protected abstract void ValidarEspecifico(List<string> erros);
    }
}
