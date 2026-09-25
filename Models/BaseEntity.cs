namespace Pet_Adoption_API.Models
{
    public class BaseEntity
    {
        public int Id {get;set;}

        public string Name {get;set;}

        public bool IsDeleted {get;set;}

        public string Category {get;set;}
    }
}