namespace ExerciciosTDD.Domain
{
    public class Animal
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public string Foto { get; set; }
        public Dono Dono { get; set; }

        public virtual string QuantoDevoComer(int pesoKg)
        {
            throw new NotImplementedException();
        }

        public virtual void Validar() // Virtual serve para permitir override nas classes filhas
        {
            var mensagens = new List<string>();

            if (string.IsNullOrWhiteSpace(Nome)) // Verificação do nome vazio
                mensagens.Add("Inserir o nome do cachorro é obrigatório.");

            if (Sexo != Sexo.Macho && Sexo != Sexo.Femea) // Verificação do sexo
                mensagens.Add("Sexo do cachorro deve ser Macho ou Fêmea.");

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
