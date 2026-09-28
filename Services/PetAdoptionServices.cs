using Pet_Adoption_API.Data;
using Pet_Adoption_API.Models;

namespace Pet_Adoption_API.Services
{
    public class PetAdoptionServices : IPetAdoptionServices
    {
        private AppDbContext _db;

        public PetAdoptionServices(AppDbContext db)
        {
            _db = db;
        }
     
        private static List<Pets> _petList = [
            new Pets {Id = 1, Name = "Zoey", Species = "Dog", Breed = "Husky", Age = 8, IsAdopted = true, IsDeleted = false},
            new Pets {Id = 1, Name = "Ruger", Species = "Dog", Breed = "Husky", Age = 8, IsAdopted = true, IsDeleted = false},
            new Pets {Id = 1, Name = "Zeus", Species = "Cat", Breed = "Maine Coon", Age = 2, IsAdopted = false, IsDeleted = false}
            


        ];

        static int newId = 4;


        public List<Pets> GetAll()
        {
            return _petList;
        }

        public List<Pets> GetByCategory(string Category)
        {
            IEnumerable<Pets> result = _petList;

            result = result.Where(c => c.Category == Category);

            return result.ToList();
        }





        public Pets GetById(int id)
        {
            Pets? item = _petList.Find(p => p.Id == id);


            return item;
        }

        public Pets AddPets(Pets newPet)
        {
            newPet.Id = newId;
            newId++;

            _petList.Add(newPet);

            return newPet;
        }

        public bool Update(int id, Pets item)
        {
            
          Pets exsisting = _petList.Find(p => p.Id == id);

          if (exsisting == null)
            {
                return false;
            }


            exsisting.Name = item.Name;
            exsisting.Category = item.Category;
            exsisting.Species = item.Species;
            exsisting.Breed = item.Breed;
            exsisting.Age = item.Age;
            exsisting.IsAdopted = item.IsAdopted;
            exsisting.IsDeleted = item.IsDeleted;





            return true;

        }

        public bool Delete(int id)
        {
            Pets? exsistingItem = _petList.Find(p => p.Id == id);

             if (exsistingItem is null)
            {
                return false;
            }

            _petList.Remove(exsistingItem);

            return true;
        }
         public Pets PatchPets(int id, Pets changes)
        {
            Pets? existingPets = _db.Pets.Find(id);

            if(existingPets == null)
            {
                return null;
            }
            if (string.IsNullOrWhiteSpace(changes.Name))
            {
                existingPets.Name = changes.Name;
            }


            if(string.IsNullOrWhiteSpace(changes.Species) != true)
            {
                existingPets.Species = changes.Species;
            }

            if (!string.IsNullOrWhiteSpace(changes.Breed))
            {
                existingPets.Breed = changes.Breed;
            }
             if ( changes.Age == 0)
            {
                existingPets.Age = changes.Age;
            }


            if(changes.IsAdopted == true)
            {
                existingPets.IsAdopted = changes.IsAdopted;
            }

            if (changes.IsDeleted == true)
            {
                existingPets.IsDeleted = changes.IsDeleted;
            }


            

            _db.SaveChanges();

            return existingPets;












            
        }

private static List<Staff> _staffList = [
            new Staff {Id = 1, Name = "Joe", LastName = "Smith", Email = "Joesmith23@gmail.com", Salary = 47552 , JobTitle = "Registered Veterinary Technician", IsWorking = false},
            new Staff {Id = 1, Name = "Haylie", LastName = "Brown", Email = "Hayliebrown113@gmail.com", Salary = 37000, JobTitle = "Kennel Technician", IsWorking = true},
            new Staff {Id = 1, Name = "Luis",LastName = "Sanchez", Email = "Luissanchez23@yahoo.com", Salary = 36915, JobTitle = "Animal Services Assistant", IsWorking = false}
            


        ];

        static int newMemberId = 4;


        public List<Staff> GetAllStaff()
        {
            return _staffList;
        }

        public List<Staff> GetStaffByCategory(string Category)
        {
            IEnumerable<Staff> result = _staffList;

            result = result.Where(c => c.Category == Category);

            return result.ToList();
        }





        public Staff GetStaffById(int id)
        {
            Staff? item = _staffList.Find(p => p.Id == id);


            return item;
        }

        public Staff Create(Staff item)
        {
            item.Id = newId;
            newId++;

            _staffList.Add(item);

            return item;
        }

        public bool Update(int id, Staff item)
        {
            
          Staff exsisting = _staffList.Find(p => p.Id == id);

          if (exsisting == null)
            {
                return false;
            }


            exsisting.Name = item.Name;
            exsisting.Category = item.Category;
            exsisting.LastName = item.LastName;
            exsisting.Email = item.Email;
            exsisting.JobTitle = item.JobTitle;
            exsisting.Salary = item.Salary;
            exsisting.IsWorking= item.IsWorking;





            return true;

        }

        public bool DeleteStaff(int id)
        {
            Staff? exsistingItem = _staffList.Find(p => p.Id == id);

             if (exsistingItem is null)
            {
                return false;
            }

            _staffList.Remove(exsistingItem);

            return true;
        }

        
    }
}