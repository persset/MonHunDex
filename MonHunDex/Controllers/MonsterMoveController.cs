using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.MonsterMove;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterMoveController : ControllerBase
    {
        private readonly IMonsterMoveService monsterMoveService;

        public MonsterMoveController(IMonsterMoveService monsterMoveService)
        {
            this.monsterMoveService = monsterMoveService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MonsterMove>>> GetAllMonsterMoves()
        {
            return await monsterMoveService.GetAllMonsterMoves();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterMove>> GetSingleMonsterMove(int id)
        {
            var result = await monsterMoveService.GetSingleMonsterMove(id);

            if (result is null)
                return NotFound("Monster move not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MonsterMove>> CreateMonsterMove(MonsterMove monsterMove)
        {
            var result = await monsterMoveService.CreateMonsterMove(monsterMove);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MonsterMove>> UpdateMonsterMove(int id, MonsterMove request)
        {
            var result = await monsterMoveService.UpdateMonsterMove(id, request);

            if (result is null)
                return NotFound("Monster move not found to update");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterMove>> DeleteMonsterMove(int id)
        {
            var result = await monsterMoveService.DeleteMonsterMove(id);

            if (result is null)
                return NotFound("Monster move not found to delete");

            return Ok(result);
        }
    }
}
