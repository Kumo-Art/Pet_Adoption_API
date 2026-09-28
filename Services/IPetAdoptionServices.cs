using Pet_Adoption_API.Models;

namespace Pet_Adoption_API.Services
{
    public interface IPetAdoptionServices
    {
        List<Pets> GetAll();


        List<Pets> GetByCategory(string Category);

        Pets GetById(int id);

        Pets AddPets(Pets newpet);

        

        Pets PatchPets(int id, Pets changes);

        bool Update(int id, Pets item);

        bool Delete(int id);


         List<Staff> GetAllStaff();


        List<Staff> GetStaffByCategory(string Category);

        Staff GetStaffById(int id);

        Staff Create(Staff item);

        bool Update(int id, Staff item);

        bool DeleteStaff(int id);
    }
}