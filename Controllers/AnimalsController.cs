using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZooManagment.Models;

namespace ZooManagment.Controllers;

[ApiController]
[Route("/animals")] //  to create rooting

public class AnimalsControllers : Controller
{
    private readonly Zoo _zoo;  // It's need access to the zoo

    public AnimalsControllers(Zoo zoo)  // to stash my incoming zoo I need private field
    {
        _zoo = zoo;
    }
    [HttpGet("{id}")]  


    // get animal by id
    public IActionResult GetById([FromRoute] int id)
    {
        var matchingAnimal = _zoo.Animals
        .Include(Animal => Animal.Species)
        .SingleOrDefault(animal => animal.Id == id);
        if (matchingAnimal == null)
        {
            return NotFound();
        }
        return Ok(matchingAnimal);
    }

}



