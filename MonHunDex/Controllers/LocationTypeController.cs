using Microsoft.AspNetCore.Mvc;
using MonHunDex.Models;
using MonHunDex.Services.LocationType;

namespace MonHunDex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationTypeController : ControllerBase
    {
        private readonly ILocationTypeService locationTypeService;

        public LocationTypeController(ILocationTypeService locationTypeService)
        {
            this.locationTypeService = locationTypeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<LocationType>>> GetAllLocationTypes()
        {
            return await locationTypeService.GetAllLocationTypes();
        }

        [HttpGet("{id}")]
        public async  Task<ActionResult<LocationType>> GetSingleLocationType(int id)
        {
            var result = await locationTypeService.GetSingleLocationType(id);

            if (result is null)
                return NotFound("The location specified was not found");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<LocationType>> CreateLocationType(LocationType locationType)
        {
            var result = await locationTypeService.CreateLocationType(locationType);

            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<LocationType>> UpdateLocationType(int id, LocationType request)
        {
            var result = await locationTypeService.UpdateLocationType(id, request);

            if (result is null)
                return NotFound("The location type you are trying to update was not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<LocationType>> DeleteLocationType(int id)
        {
            var result = await locationTypeService.DeleteLocationType(id);

            if (result is null)
                return NotFound("Location type not found");

            return Ok(result);
        }
    }
}
