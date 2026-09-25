using Pet_Adoption_API.Models;

namespace Pet_Adoption_API.Services
{
    public interface IPetAdoptionServices
    {
        List<Pets> GetAll();


        List<Pets> GetByCategory(string Category);

        Pets GetById(int id);

        Pets Create(Pets item);

        bool Update(int id, Pets item);

        bool Delete(int id);
    }
}