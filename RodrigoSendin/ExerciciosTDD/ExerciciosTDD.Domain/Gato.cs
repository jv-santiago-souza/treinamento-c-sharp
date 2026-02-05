namespace ExerciciosTDD.Domain
{
    public class Gato : IPet
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public string Foto { get; set; }
        public Dono Dono { get; set; }

        public string quantoDevoComer(int pesoKg)
        {
            throw new NotImplementedException();
        }

        public void validar()
        {
            throw new NotImplementedException();
        }
    }
}
