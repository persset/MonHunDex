using MonHunDex.Data;

namespace MonHunDex.Services.Location
{
    public class LocationService : ILocationService
    {
        private readonly DataContext dataContext;

        public LocationService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Location> CreateLocation(Models.Location location)
        {
            dataContext.Locations.Add(location);
            await dataContext.SaveChangesAsync();

            return location;
        }

        public async Task<Models.Location?> DeleteLocation(int id)
        {
            var location = await dataContext.Locations.FindAsync(id);

            if (location is null)
                return null;

            dataContext.Locations.Remove(location);
            await dataContext.SaveChangesAsync();

            return location;
        }

        public async Task<List<Models.Location>> GetAllLocations()
        {
            return await dataContext.Locations.ToListAsync();
        }

        public async Task<Models.Location?> GetSingleLocation(int id)
        {
            var location = await dataContext.Locations.FindAsync(id);

            if (location is null)
                return null;

            return location;
        }

        public async Task<Models.Location?> UpdateLocation(int id, Models.Location request)
        {
            var location = await dataContext.Locations.FindAsync(id);

            if (location is null)
                return null;

            location.Name = request.Name;
            location.Description = request.Description;
            location.LocationTypeId = request.LocationTypeId;

            await dataContext.SaveChangesAsync();

            return location;
        }
    }
}
