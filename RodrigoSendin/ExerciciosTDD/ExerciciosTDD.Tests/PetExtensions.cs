using ExerciciosTDD.Domain;

namespace ExerciciosTDD.Tests
{
    public static class PetExtensions
    {
        public static string GetTipo(this IPet pet)
        {
            return pet.GetType().Name;
        }
    }
}
