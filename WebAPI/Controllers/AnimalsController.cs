using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        IAnimalService _animalService;

        public AnimalsController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        [HttpGet]

        public IActionResult Get()
        {

            var result = _animalService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
            
        }

        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            var result = _animalService.Add(animal);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
