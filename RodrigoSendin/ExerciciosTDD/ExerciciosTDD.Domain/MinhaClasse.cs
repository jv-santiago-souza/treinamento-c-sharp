namespace ExerciciosTDD.Domain
{
    public class MinhaClasse
    {
        private void MeuMetodo()
        {
        }

        public void OutroMetodo()
        {
            MeuMetodo();
        }
    }

    public class ClasseFilha : MinhaClasse
    {
        public void MetodoDaClasseFilha()
        {
            OutroMetodo();
        }
    }
}
