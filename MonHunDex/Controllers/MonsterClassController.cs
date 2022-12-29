using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.MonsterClass;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterClassController : ControllerBase
    {
        private readonly IMonsterClassService monsterClassService;

        public MonsterClassController(IMonsterClassService monsterClassService)
        {
            this.monsterClassService = monsterClassService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MonsterClass>>> GetAllMonsterClasses()
        {
            return await monsterClassService.GetAllMonsterClasses();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterClass>> GetSingleMonsterClass(int id)
        {
            var result = await monsterClassService.GetSingleMonsterClass(id);

            if (result is null)
                return NotFound("Monster class not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MonsterClass>> CreateMonterClass(MonsterClass monsterClass)
        {
            var result = await monsterClassService.CreateMonsterClass(monsterClass);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MonsterClass>> UpdateMonsterClass(int id, MonsterClass request)
        {
            var result = await monsterClassService.UpdateMonsterClass(id, request);

            if (result is null)
                return NotFound("Monster class not found to update");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterClass>> DeleteMonsterClass(int id)
        {
            var result = await monsterClassService.DeleteMonsterClass(id);

            if (result is null)
                return NotFound("Monster class not found to delete");

            return Ok(result);
        }
    }
}
