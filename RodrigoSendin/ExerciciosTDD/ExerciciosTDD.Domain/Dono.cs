namespace ExerciciosTDD.Domain
{
    public class Dono
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public List<IPet> Pets { get; set; } // Associação 1:N (um dono pode ter vários * pets *)

        public void AddPet(IPet pet)
        {
            if (Pets == null)
                Pets = new List<IPet>();
            
            Pets.Add(pet);

            pet.Dono = this; // Estabelece a relação bidirecional
        }

        public void AddPet(params IPet[] pets)
        {
            foreach (var pet in pets)
            {
                AddPet(pet);
            }
        }

        public void RemovePet(IPet pet)
        {
            if (Pets == null)
                return;

            if (Pets.Remove(pet))
                pet.Dono = null; // Remove a relação bidirecional
        }

        public void RemovePet(params IPet[] pets)
        {
            foreach (var pet in pets)
            {
                RemovePet(pet);
            }
        }
    }
}