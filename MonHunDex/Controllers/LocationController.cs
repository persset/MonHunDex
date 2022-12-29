using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.Location;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Location>>> GetAllLocations()
        {
            return await locationService.GetAllLocations();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetSingleLocation(int id)
        {
            var result = await locationService.GetSingleLocation(id);

            if (result is null)
                return NotFound("The location you were trying to get was not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Location>> CreateLocation(Location location)
        {
            var result = await locationService.CreateLocation(location);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Location>> UpdateLocation(int id, Location request)
        {
            var result = await locationService.UpdateLocation(id, request);

            if (result is null)
                return NotFound("The location you were trying to update was not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Location>> DeleteLocation(int id)
        {
            var result = await locationService.DeleteLocation(id);

            if (result is null)
                return NotFound("The location you are trying to delete was not found");

            return Ok(result);
        }
    }
}
