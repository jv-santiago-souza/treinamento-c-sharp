



namespace ExerciciosTDD.Domain
{
    public class Cachorro
    {
        #region Nome
        public void setNome(string nome)
        {
            _nome = nome;
        }
        public string getNome()
        {
            return _nome;
        }
        private string _nome;
        #endregion

        #region Sexo
        public void setSexo(string sexo)
        {
            _sexo = sexo;
        }
        public string getSexo()
        {
            return _sexo;
        }
        private string _sexo;
        #endregion

        #region Raça
        public void setRaca(string raca)
        {
            _raca = raca;
        }
        public string getRaca()
        {
            return _raca;
        }
        private string _raca;
        #endregion

        #region Porte
        public void setPorte(string porte)
        {
            _porte = porte;
        }
        public string getPorte()
        {
            return _porte;
        }
        private string _porte;
        #endregion

        #region Idade
        public void setIdade(int idade)
        {
            _idade = idade;
        }
        public int getIdade()
        {
            return _idade;
        }
        private int _idade;
        #endregion

        #region Peso
        public void setPeso(double peso)
        {
            _peso = peso;
        }
        public double getPeso()
        {
            return _peso;
        }
        private double _peso;
        #endregion


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
