using System.Text;
using static ExerciciosTDD.Domain.Especie;

namespace ExerciciosTDD.Domain
{
    public class Cachorro : Animal, IPet
    {
        #region Nome

        // public string? Nome { set; get; } --- Ocultado pois herdado de Animal

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

        //public Sexo Sexo { set; get; } --- Ocultado pois herdado de Animal

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

        public Raca? Raca { set; get; } // Posso passar um Privatete para o set, ou seja, read-only de fora.
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

        public Raca.Porte Porte { set; get; }

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

        #region Peso

        // public double Peso { set; get; } --- Ocultado pois herdado de Animal

        //public void setPeso(double peso)
        //{
        //    _peso = peso;
        //}
        //public double getPeso()
        //{
        //    return _peso;
        //}
        //private double _peso;
        #endregion

        #region Vacinado

        public string? Vacinado { set; get; }

        // public string Foto { get; set; } --- Ocultado pois herdado de Animal

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

        public DateTime DataNascimento { set; get; }

        protected override EspecieAnimal Especie => EspecieAnimal.Cachorro;

        // public Dono? Dono { set; get; } --- Ocultado pois herdado de Animal

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

        public override string QuantoDevoComer() // Use instance Peso instead of parameter
        {
            return $"como tenho {Peso}kg, devo comer {Peso * 50}g por dia"; // 50g por kg(1000 * 5%);
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
            if (dataAtual.Day < dataNascConvertido.Day) mesesTotais--;

            if (mesesTotais < 12) 
                return mesesTotais == 0 ? "Tenho menos de 1 mês" : mesesTotais == 1 ? "Tenho 1 mês" : $"Tenho {mesesTotais} meses";

            int anos = mesesTotais / 12;

            return anos == 1 ? $"Tenho {anos} ano" : $"Tenho {anos} anos";
        }

        protected override void ValidarEspecifico(List<string> erros)
        {
            if (DataNascimento == default) erros.Add("Data de nascimento é obrigatória.");

            if (DataNascimento > DateTime.Today) erros.Add("A data de nascimento do cachorro não pode ser no futuro.");
        }
    }
}