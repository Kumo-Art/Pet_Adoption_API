namespace Pet_Adoption_API.Models
{
    public class Pets : BaseEntity
    {
        public string Species {get;set;}

        public string Breed {get;set;}

        public int Age {get;set;}

        public bool IsAdopted {get;set;}
    }
}