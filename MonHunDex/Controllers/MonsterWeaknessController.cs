using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.MonsterWeakness;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterWeaknessController : ControllerBase
    {
        private readonly IMonsterWeaknessService monsterWeaknessService;

        public MonsterWeaknessController(IMonsterWeaknessService monsterWeaknessService)
        {
            this.monsterWeaknessService = monsterWeaknessService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MonsterWeakness>>> GetAllMonsterWeaknesses()
        {
            return await monsterWeaknessService.GetAllMonsterWeaknesses();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterWeakness>> GetSingleMonsterWeakness(int id)
        {
            var result = await monsterWeaknessService.GetSingleMonsterWeakness(id);

            if (result is null)
                return NotFound("Monster weakness not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MonsterWeakness>> CreateMonsterWeakness(MonsterWeakness monsterWeakness)
        {
            var result = await monsterWeaknessService.CreateMonsterWeakness(monsterWeakness);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MonsterWeakness>> UpdateMonsterWeakness(int id, MonsterWeakness request)
        {
            var result = await monsterWeaknessService.UpdateMonsterWeakness(id, request);

            if (result is null)
                return NotFound("Monster weakness not found to update");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterWeakness>> DeleteMonsterWeakness(int id)
        {
            var result = await monsterWeaknessService.DeleteMonsterWeakness(id);

            if (result is null)
                return NotFound("Monster weakness not found to delete");

            return Ok(result);
        }
    }
}
