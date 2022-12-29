using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.MonsterLocation;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterLocationController : ControllerBase
    {
        private readonly IMonsterLocationService monsterLocationService;

        public MonsterLocationController(IMonsterLocationService monsterLocationService)
        {
            this.monsterLocationService = monsterLocationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<MonsterLocation>>> GetAllMonsterLocations()
        {
            return await monsterLocationService.GetAllMonsterLocations();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MonsterLocation>> GetSingleMonsterLocation(int id)
        {
            var result = await monsterLocationService.GetSingleMonsterLocation(id);

            if (result is null)
                return NotFound("Monster location not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<MonsterLocation>> CreateMonsterLocation(MonsterLocation monsterLocation)
        {
            var result = await monsterLocationService.CreateMonsterLocation(monsterLocation);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<MonsterLocation>> UpdateMonsterLocation(int id, MonsterLocation request)
        {
            var result = await monsterLocationService.UpdateMonsterLocation(id, request);

            if (result is null)
                return NotFound("Monster location not found to update");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MonsterLocation>> DeleteMonsterLocation(int id)
        {
            var result = await monsterLocationService.DeleteMonsterLocation(id);

            if (result is null)
                return NotFound("Monster not found to delete");

            return Ok(result);
        }
    }
}
