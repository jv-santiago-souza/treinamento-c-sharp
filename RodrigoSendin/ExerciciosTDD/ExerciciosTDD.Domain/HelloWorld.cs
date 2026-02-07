namespace ExerciciosTDD.Domain
{
    public static class HelloWorld
    {
        public static string SayHello()
        {
            return "Hello, World!";
        }

        public static async Task<List<IPet>> Ler_Pets_Do_ArquivoAsync(string caminho)
        {
            List<IPet> listaDePets = new();

            if (!File.Exists(caminho))
            {
                throw new Exception("Arquivo não encontrado!");
            }

            using StreamReader leitor = new(caminho);

            await leitor.ReadLineAsync(); // Pula o cabeçalho

            while (!leitor.EndOfStream)
            {
                string? linha = await leitor.ReadLineAsync();
                if (string.IsNullOrWhiteSpace(linha)) continue;

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

                if (tipo.Equals("Cachorro", StringComparison.OrdinalIgnoreCase))
                {
                    Cachorro cachorro = new()
                    {
                        Nome = nome,
                        Peso = Convert.ToDouble(pesoTexto),
                        Sexo = (sexoTexto == "Macho") ? Sexo.Macho : Sexo.Femea,
                        Dono = new Dono { Nome = donoNome },
                        Raca = new Raca { Nome = racaTexto }
                    };

                    if (!string.IsNullOrWhiteSpace(dataNascTexto))
                        cachorro.DataNascimento = Convert.ToDateTime(dataNascTexto);

                    cachorro.setVacinado(vacinadoTexto == "sim");

                    listaDePets.Add(cachorro);
                }
                else if (tipo.Equals("Gato", StringComparison.OrdinalIgnoreCase))
                {
                    Gato gato = new()
                    {
                        Nome = nome,
                        Peso = Convert.ToDouble(pesoTexto),
                        Sexo = (sexoTexto == "Macho") ? Sexo.Macho : Sexo.Femea,
                        Dono = new Dono { Nome = donoNome }
                    };

                    listaDePets.Add(gato);
                }
            }

            return listaDePets;
        }


        public static string Tarefa(string tarefa, int passos)
        {
            Console.WriteLine($"## Tarefa {tarefa} INICIADA!");

            for (var i = passos; i > 0; i--)
            {
                Thread.Sleep(1000);
                Console.WriteLine($"     >> Tarefa {tarefa} executando... {i}");
            }

            return $"## Tarefa {tarefa} FINALIZADA!";
        }

        public static async Task<string> TarefaAsync(string tarefa, int passos)
        {
            Console.WriteLine($"## Tarefa {tarefa} INICIADA!");

            for (var i = passos; i > 0; i--)
            {
                await Task.Delay(1000);
                Console.WriteLine($"     >> Tarefa {tarefa} executando... {i}");
            }

            return $"## Tarefa {tarefa} FINALIZADA!";
        }
    }
}