using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.MonsterElement;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterElementController : ControllerBase
    {
        private readonly IMonsterElementService monsterElementService;

        public MonsterElementController(IMonsterElementService monsterElementService)
        {
            this.monsterElementService = monsterElementService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MonsterElement>>> GetAllMonsterElements()
        {
            return await monsterElementService.GetAllMonsterElements();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterElement>> GetSingleMonsterElement(int id)
        {
            var result = await monsterElementService.GetSingleMonsterElement(id);

            if (result is null)
                return NotFound("Monster element not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MonsterElement>> CreateMonsterElement(MonsterElement monsterElement)
        {
            var result = await monsterElementService.CreateMonsterElement(monsterElement);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MonsterElement>> UpdateMonsterElement(int id, MonsterElement request)
        {
            var result = await monsterElementService.UpdateMonsterElement(id, request);

            if (result is null)
                return NotFound("Monster element not found to update");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterElement>> DeleteMonsterElement(int id)
        {
            var result = await monsterElementService.DeleteMonsterElement(id);

            if (result is null)
                return NotFound("Monster element not found to delete");

            return Ok(result);
        }
    }
}
