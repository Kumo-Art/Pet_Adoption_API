using System.Reflection.Metadata.Ecma335;
using Pet_Adoption_API.Models;

namespace Pet_Adoption_API.Services
{
    public class PetAdoptionServices : IPetAdoptionServices
    {
        private static List<Pets> _petList = [
            new Pets {Id = 1, Name = "Zoey", Species = "Dog", Breed = "Husky", Age = 8, IsAdopted = true, IsDeleted = false}
            


        ];

        static int newId = 2;


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

        public Pets Create(Pets item)
        {
            item.Id = newId;
            newId++;

            _petList.Add(item);

            return item;
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
        
    }
}