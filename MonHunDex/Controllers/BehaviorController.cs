using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.Behavior;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BehaviorController : ControllerBase
    {
        private readonly IBehaviorService behaviorService;

        public BehaviorController(IBehaviorService behaviorService)
        {
            this.behaviorService = behaviorService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Behavior>>> GetAllBehaviors()
        {
            return await behaviorService.GetAllBehaviors();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Behavior>> GetSingleBehavior(int id)
        {
            var result = await behaviorService.GetSingleBehavior(id);

            if (result is null)
                return NotFound("Behavior not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Behavior>> CreateBehavior(Behavior behavior)
        {
            var result = await behaviorService.CreateBehavior(behavior);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Behavior>> UpdateBehavior(int id, Behavior request)
        {
            var result = await behaviorService.UpdateBehavior(id, request);

            if (result is null)
                return NotFound("Behavior to update not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Behavior>> DeleteBehavior(int id)
        {
            var result = await behaviorService.DeleteBehavior(id);

            if (result is null)
                return NotFound("Behavior to delete not found");

            return Ok(result);
        }
    }
}
