using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosTDD.Domain
{
    public interface IPet
    {
        // Declarações de visibilidade não devem ser definidos aqui na interface, mas sim na classe que a implementa
        string Nome { get; set; }
        Sexo Sexo { get; set; }
        string Foto { get; set; }
        Dono Dono { get; set; }

        string quantoDevoComer(int pesoKg);
        void validar();

    }
}
