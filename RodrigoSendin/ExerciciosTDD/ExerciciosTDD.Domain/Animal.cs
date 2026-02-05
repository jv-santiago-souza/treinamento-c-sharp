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
            throw new NotImplementedException();
        }
    }
}
