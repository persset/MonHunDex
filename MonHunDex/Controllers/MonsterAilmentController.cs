using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.MonsterAilments;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterAilmentController : ControllerBase
    {
        private readonly IMonsterAilmentService monsterAilmentService;

        public MonsterAilmentController(IMonsterAilmentService monsterAilmentService)
        {
            this.monsterAilmentService = monsterAilmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MonsterAilment>>> GetAllMonsterAilments()
        {
            return await monsterAilmentService.GetAllMonsterAilments();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterAilment>> GetSingleMonsterAilment(int id)
        {
            var result = await monsterAilmentService.GetSingleMonsterAilment(id);

            if(result is null)
                return NotFound("Monster ailment not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MonsterAilment>> CreateMonsterAilment(MonsterAilment monsterAilment)
        {
            var result = await monsterAilmentService.CreateMonsterAilment(monsterAilment);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MonsterAilment>> UpdateMonsterAilment(int id, MonsterAilment request)
        {
            var result = await monsterAilmentService.UpdateMonsterAilment(id, request);

            if (result is null)
                return NotFound("Monster ailment not found to update");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterAilment>> DeleteMonsterAilment(int id)
        {
            var result = await monsterAilmentService.DeleteMonsterAilment(id);

            if (result is null)
                return NotFound("Monster ailment not found to delete");

            return Ok(result);
        }
    }
}
