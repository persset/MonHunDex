using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.Ailment;

namespace MonHunDex.Controllers
{
    public class AilmentController : ControllerBase
    {
        private readonly IAilmentService ailmentService;

        public AilmentController(IAilmentService ailmentService)
        {
            this.ailmentService = ailmentService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ailment>>> GetAllAilments()
        {
            return await ailmentService.GetAllAilments();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ailment>> GetSingleAilment(int id)
        {
            var result = await ailmentService.GetSingleAilment(id);
            if (result is null)
                return NotFound("Ailment not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Ailment>> CreateAilment(Ailment ailment)
        {
            var result = await ailmentService.CreateAilment(ailment);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Ailment>> UpdateAilment(int id, Ailment request)
        {
            var result = await ailmentService.UpdateAilment(id, request);

            if (result is null)
                return NotFound("Ailment to update not found!");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Ailment>> DeleteAilment(int id)
        {
            var result = await ailmentService.DeleteAilment(id);

            if (result is null)
                return NotFound("Ailment to delete not found");

            return Ok(result);
        }
    }
}
