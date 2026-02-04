using System.Text;

namespace ExerciciosTDD.Domain
{
    public class Cachorro
    {
        #region Nome

        public string? Nome { set; get; }

        //public void setNome(string nome)
        //{
        //    _nome = nome;
        //}
        //public string getNome()
        //{
        //    return _nome;
        //}
        //private string _nome;
        #endregion

        #region Sexo

        public string? Sexo { set; get; }

        //public void setSexo(string sexo)
        //{
        //    _sexo = sexo;
        //}
        //public string getSexo()
        //{
        //    return _sexo;
        //}
        //private string _sexo;
        #endregion

        #region Raça

        // Propriedades, por convenção, são publicas e começam com letra maiúscula
        // Abaixo, temos a estrutura de uma propriedade em C#
        // Para ter uma propriedade, ainda precisamos de um campo privado para armazenar o valor (atributo)

        // Estrutura antiga
        //public string Raca
        //{
        //    get { return _raca; }
        //    set { _raca = value; }
        //}

        public string? Raca { set; get; } // Posso passar um Privatete para o set, ou seja, read-only de fora.
                                          // Também dá pra incluir apenas um dos dois, ou get, ou set, para ter uma propriedade de apenas leitura ou escrita.

        //public void setRaca(string raca)
        //{
        //    _raca = raca;
        //}
        //public string getRaca()
        //{
        //    return _raca;
        //}
        //private string? _raca;
        #endregion

        #region Porte

        public string? Porte { set; get; }

        //public void setPorte(string porte)
        //{
        //    _porte = porte;
        //}
        //public string getPorte()
        //{
        //    return _porte;
        //}
        //private string _porte;
        #endregion

        public string? DataNascimento { set; get; }

        #region Peso

        public string? Peso { set; get; }

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

        #region Vacinado

        public string? Vacinado { set; get; }

        public void setVacinado(bool vacinado)
        {
            _vacinado = vacinado;
        }
        public bool getVacinado()
        {
            return _vacinado;
        }
        private bool _vacinado;
        #endregion


        public string Latir(short qtdeLatidos)
        {
            if (qtdeLatidos <= 0) return string.Empty;

            var latido = "Au! ";
            var builder = new StringBuilder();

            for (var i = 0; i < qtdeLatidos; i++)
            {
                builder.Append(latido);
            }

            return builder.ToString();
        }

        public string QuantoDevoComer(int pesoKg) // Método para 5% do peso (em kg) do cachorro em gramas de ração por dia
        {
            return $"como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia"; // 50g por kg(1000 * 5%);
        }

        public static string IdadeCachorro(string dataNascimento)
        {
            var dataAtual = DateTime.Today;
            var dataNascConvertido = DateTime.Parse(dataNascimento);

            var mesesTotais = ((dataAtual.Year - dataNascConvertido.Year) * 12) + dataAtual.Month - dataNascConvertido.Month;

            if (mesesTotais < 0) // Data de nascimento no futuro; impossível NESSE contexto
            {
                return "Data de nascimento inválida";
            }

            // Se o dia do mês atual for menor que o dia de nascimento, ainda não completou o mês
            if (dataAtual.Day < dataNascConvertido.Day) mesesTotais --;

            if (mesesTotais < 12)

                if (mesesTotais == 0)
                {
                    return "Tenho menos de 1 mês";
                }
                else

                {
                return mesesTotais == 1 ? "Tenho 1 mês" : $"Tenho {mesesTotais} meses";
            }

            int anos = mesesTotais / 12;

            if (anos == 1)
            {
                return $"Tenho {anos} ano";
            }
            else
            {
                return $"Tenho {anos} anos";
            }
        }

    }
}
