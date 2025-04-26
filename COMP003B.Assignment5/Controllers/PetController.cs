using COMP003B.Assignment5.Data;
using COMP003B.Assignment5.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment5.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class PetController : ControllerBase
	{
		[HttpGet]
		public ActionResult<List<Pets>> GetPets()
		{
			return Ok(PetExample.PetDescription);
		}

		[HttpGet("{id}")]
		public ActionResult<Pets> GetPetId(int id)
		{
			var pet = PetExample.PetDescription.FirstOrDefault(a => a.Id == id);
			if (pet == null)
			{
				return NotFound();
			}
			return Ok(pet);
		}

		[HttpPost]
		public ActionResult <Pets> CreatePet(Pets newPet)
		{
			PetExample.PetDescription.Add(newPet);

			return CreatedAtAction(nameof(GetPetId), new { id = newPet.Id }, newPet);
		}

		[HttpPut("{id}")]
		public ActionResult UpdatePet(int id, Pets updatedPet)
		{
			var existingPet = PetExample.PetDescription.FirstOrDefault(p => p.Id == id);
			if (existingPet == null)
			{
				return NotFound();
			}

			existingPet.Id = updatedPet.Id;
			existingPet.Name = updatedPet.Name;
			existingPet.Age = updatedPet.Age;

			return NoContent();
		}

		[HttpDelete("{id}")]
		public ActionResult DeletePet(int id)
		{
			var pet = PetExample.PetDescription.FirstOrDefault(p => p.Id == id);

			if (pet == null)
			{ return NotFound(); }

			PetExample.PetDescription.Remove(pet);
			return NoContent();
		}
			
	}
}
