using Microsoft.AspNetCore.Mvc;

namespace WebApplication1;

public class AnimalsService:ControllerBase
{
    private List<Animal> _animals = new List<Animal>() { new Animal(1,"adf",2.1,"test","czerwony"),new Animal(2,"adasdff",2.6,"test2","zolty")};
    [HttpGet("animals")]
    public ActionResult<IEnumerable<Animal>> GetAnimals()
    {
        return Animals.AnimalsList.ToList();
    }
    [HttpGet("animals/{id}")]
    public ActionResult<Animal> GetAnimalById(int id)
    {
        return Animals.AnimalsList.FirstOrDefault(a => a.Id == id);
    }
    [HttpPost("animals")]
    public IActionResult PostAnimal(Animal animal){
        animal.Id = Animals.AnimalsList.Count +1;
        Animals.AnimalsList.Add(animal);
        return CreatedAtAction(nameof(GetAnimalById), new { id = animal.Id }, animal);
    }
    [HttpPut("animals/{id}")]
    public IActionResult PutAnimal(int id, Animal animal){
        var animal1 = Animals.AnimalsList.FirstOrDefault(a => a.Id == id);
        
        animal1.Imie = animal1.Imie;
        animal1.Kategoria = animal1.Kategoria;
        animal1.Masa= animal1.Masa;
        animal1.KolorSierci = animal1.KolorSierci;
        return NoContent();
    }
    [HttpDelete("animals/{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            var animal = Animals.AnimalsList.FirstOrDefault(a => a.Id == id);

            Animals.AnimalsList.Remove(animal);
            return NoContent();
        }
}