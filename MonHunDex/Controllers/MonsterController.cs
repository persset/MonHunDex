using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.Monster;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : ControllerBase
    {
        private readonly IMonsterService monsterService;
        public MonsterController(IMonsterService monsterService)
        {
            this.monsterService = monsterService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Monster>>> GetAllMonsters()
        {
            return await monsterService.GetAllMonsters();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Monster>> GetSingleMonster(int id)
        {
            var result = await monsterService.GetSingleMonster(id);
            if (result is null)
                return NotFound("Monster Not Found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Monster>> CreateMonster(Monster monster)
        {
            var result = await monsterService.CreateMonster(monster);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Monster>> UpdateMonster(int id, Monster request)
        {
            var result = await monsterService.UpdateMonster(id, request);
            if (result is null)
                return NotFound("Monster to update not found");

            return Ok(result);
        }
    }
}
