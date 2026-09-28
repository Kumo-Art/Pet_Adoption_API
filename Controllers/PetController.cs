using Microsoft.AspNetCore.Mvc;
using Pet_Adoption_API.Models;
using Pet_Adoption_API.Services;

namespace Pet_Adoption_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PetController : ControllerBase
    {
         private readonly IPetAdoptionServices _petList;
        
        
        public PetController(IPetAdoptionServices pets)
        {
             _petList = pets;  
        }




        [HttpGet("GetAllPets")]


        public ActionResult<List<Pets>> GetAll()
        {
            
            List<Pets> pets = _petList.GetAll();


            return Ok(pets); 
        }




        [HttpPost("Create")]

        public ActionResult<Pets> Create([FromBody] Pets newPet)
        {
            Pets createdPet = _petList.AddPets(newPet);

            return CreatedAtAction(
                nameof(GetAll),
                createdPet
            );
        }


        [HttpPut("Update/{id}")]

        public ActionResult<Pets> Update(int id, [FromBody] Pets pets)
        {
            
            Pets?  updated = _petList.Update(id, pets);

            if(updated == null)
            {
                return NotFound($"No student with Id {id}");
            }

            return NoContent();

        }

        [HttpPatch("Patch/{id}")]
        public ActionResult<Pets> Patch(int id, [FromBody] Pets pets)
        {
            Pets? change = _petList.PatchPets(id, pets);

            if(change == null)
            {
                return NotFound($"No student with Id {id}");
            }

            return NoContent();
    }
}
}