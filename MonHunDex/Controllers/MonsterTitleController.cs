using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.MonsterTitle;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterTitleController : ControllerBase
    {
        private readonly IMonsterTitleService monsterTitleService;

        public MonsterTitleController(IMonsterTitleService monsterTitleService)
        {
            this.monsterTitleService = monsterTitleService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MonsterTitle>>> GetAllMonsterTitles()
        {
            return await monsterTitleService.GetAllMonsterTitles();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterTitle>> GetSingleMonsterTitle(int id)
        {
            var result = await monsterTitleService.GetSingleMonsterTitle(id);

            if (result is null)
                return NotFound("Monster title not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MonsterTitle>> CreateMonsterTitle(MonsterTitle monsterTitle)
        {
            var result = await monsterTitleService.CreateMonsterTitle(monsterTitle);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MonsterTitle>> UpdateMonsterTitle(int id, MonsterTitle request)
        {
            var result = await monsterTitleService.UpdateMonsterTitle(id, request);

            if (result is null)
                return NotFound("Monster title not found to update");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterTitle>> DeleteMonsterTitle(int id)
        {
            var result = await monsterTitleService.DeleteMonsterTitle(id);

            if (result is null)
                return NotFound("Monster title not found to delete");

            return Ok(result);
        }
    }
}
