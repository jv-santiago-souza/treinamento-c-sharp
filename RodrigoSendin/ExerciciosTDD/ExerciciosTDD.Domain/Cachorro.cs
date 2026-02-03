


namespace ExerciciosTDD.Domain
{
    public class Cachorro
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _porte;
        private int _idade;
        private double _peso;

        public string Latir()
        {
            return "Au Au!";
        }

        public string QuantoDevoComer(int pesoKg) // Método para 5% do peso (em kg) do cachorro em gramas de ração por dia
        {
            return $"como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia"; // 50g por kg(1000 * 5%);
        }

        public void setNome(string nome)
        {
            _nome = nome;
        }
        public string getNome()
        {
            return _nome;
        }
    }
}
