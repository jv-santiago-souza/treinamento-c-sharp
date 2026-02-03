

namespace ExerciciosTDD.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au Au!";
        }

        public string QuantoDevoComer(int peso)
        {
            return $"como tenho {peso}kg, devo comer {peso * 50}g por dia";
        }
    }
}
