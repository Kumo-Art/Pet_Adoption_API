namespace Pet_Adoption_API.Models
{
    public class Staff : BaseEntity
    {
        // works today IsWorking I want their First name Last Name Email Salary and Job 
        
        public string LastName {get;set;}

        public string Email {get;set;}

        public int Salary {get;set;}

        public string JobTitle {get;set;}

        public bool IsWorking {get;set;}
    }
}