using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.Move;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoveController : ControllerBase
    {
        private readonly IMoveService moveService;

        public MoveController(IMoveService moveService)
        {
            this.moveService = moveService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Move>>> GetAllMoves()
        {
            return await moveService.GetAllMoves();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Move>> GetSingleMove(int id)
        {
            var response = await moveService.GetSingleMove(id);

            if (response is null)
                return NotFound("Move not found");

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Move>> DeleteMove(int id)
        {
            var response = await moveService.DeleteMove(id);

            if (response is null)
                return NotFound("Move not found to delete");

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Move>> UpdateMove(int id, Move request)
        {
            var response = await moveService.UpdateMove(id, request);

            if (response is null)
                return NotFound("Move not found to update");

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<Move>> CreateMove(Move move)
        {
            var response = await moveService.CreateMove(move);

            return Ok(response);
        }
    }
}
