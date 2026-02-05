using System.Text;

namespace ExerciciosTDD.Domain
{
    public class Gato : Animal, IPet
    {
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

        public override void Validar()
        {
            var mensagens = new List<string>();
            if (string.IsNullOrWhiteSpace(Nome)) // Verificação do nome vazio
                mensagens.Add("Inserir o nome do gato é obrigatório.");
            if (Sexo != Sexo.Macho && Sexo != Sexo.Femea) // Verificação do sexo
                mensagens.Add("Sexo do gato deve ser Macho ou Fêmea.");
            if (mensagens.Count > 0)
            {
                var exceptionMessage = "";
                foreach (var msg in mensagens)
                    exceptionMessage += msg + Environment.NewLine;
                throw new Exception(exceptionMessage.Trim());
            }
        }
    }
}
