using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI.Models;
using SuperHeroAPI.Services.SuperHeroService;

namespace SuperHeroAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SuperHeroController(ISuperHeroService superHeroService) : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService = superHeroService;

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return await _superHeroService.GetAllHeroes();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(Guid id)
        {
            var result = await _superHeroService.GetSingleHero(id);

            if (result is null)
                return NotFound("Герой не найден.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = await _superHeroService.AddHero(hero);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(Guid id, SuperHero request)
        {
            var result = await _superHeroService.UpdateHero(id, request);

            if (result is null)
                return NotFound("Герой не найден.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(Guid id)
        {
            var result = await _superHeroService.DeleteHero(id);

            if (result is null)
                return NotFound("Герой не найден.");

            return Ok(result);
        }
    }
}