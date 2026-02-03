

namespace ExerciciosTDD.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au Au!";
        }

        public string QuantoDevoComer(int pesoKg) // Método para 5% do peso (em kg) do cachorro em gramas de ração por dia
        {
            return $"como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia"; // 50g por kg(1000 * 5%);
        }
    }
}
