namespace ExerciciosTDD.Domain
{
    public static class HelloWorld
    {
        public static string SayHello()
        {
            return "Hello, World!";
        }

        public static List<IPet> Ler_Pets_Do_Arquivo(string caminho)
        {
            List<IPet> listaDePets = new List<IPet>();

            if (File.Exists(caminho) == false)
            {
                throw new Exception("Arquivo não encontrado!");
            }

            using (StreamReader leitor = new(caminho))
            {
                leitor.ReadLine(); // Pula o cabeçalho

                while (leitor.EndOfStream == false)
                {
                    string? linha = leitor.ReadLine();
                    if (string.IsNullOrEmpty(linha)) continue;

                    string[] colunas = linha.Split(';');

                    string tipo = colunas[0];
                    string nome = colunas[1];
                    string sexoTexto = colunas[2];
                    string donoNome = colunas[3];
                    string pesoTexto = colunas[4];
                    string racaTexto = colunas[5];
                    string porteTexto = colunas[6];
                    string dataNascTexto = colunas[7];
                    string vacinadoTexto = colunas[8];

                    if (tipo == "Cachorro" || tipo == "cachorro")
                    {
                        Cachorro cachorro = new()
                        {
                            Nome = nome,
                            Peso = Convert.ToDouble(pesoTexto),
                            Sexo = (sexoTexto == "Macho") ? Sexo.Macho : Sexo.Femea
                        };

                        Dono dono = new() { Nome = donoNome };

                        cachorro.Dono = dono;
                        cachorro.Raca = new Raca { Nome = racaTexto }; 

                        if (!string.IsNullOrWhiteSpace(dataNascTexto)) cachorro.DataNascimento = Convert.ToDateTime(dataNascTexto);

                        if (vacinadoTexto == "sim") cachorro.setVacinado(true);
                        else cachorro.setVacinado(false);

                        listaDePets.Add(cachorro);
                    }
                    else if (tipo == "Gato" || tipo == "Gato")
                    {
                        Gato gato = new()
                        {
                            Nome = nome,
                            Peso = Convert.ToDouble(pesoTexto),
                            Sexo = (sexoTexto == "Macho") ? Sexo.Macho : Sexo.Femea
                        };

                        Dono dono = new() { Nome = donoNome };

                        gato.Dono = dono;

                        listaDePets.Add(gato);
                    }
                }
            }
            return listaDePets;
        }
    }
}