using MonHunDex.Data;

namespace MonHunDex.Services.LocationType
{
    public class LocationTypeService : ILocationTypeService
    {
        private readonly DataContext dataContext;

        public LocationTypeService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.LocationType> CreateLocationType(Models.LocationType locationType)
        {
            dataContext.LocationTypes.Add(locationType);
            await dataContext.SaveChangesAsync();

            return locationType;
        }

        public async Task<Models.LocationType?> DeleteLocationType(int id)
        {
            var locationType = await dataContext.LocationTypes.FindAsync(id);

            if (locationType is null)
                return null;

            dataContext.LocationTypes.Remove(locationType);

            await dataContext.SaveChangesAsync();

            return locationType;
        }

        public async Task<List<Models.LocationType>> GetAllLocationTypes()
        {
            return await dataContext.LocationTypes.ToListAsync();
        }

        public async Task<Models.LocationType?> GetSingleLocationType(int id)
        {
            var locationType = await dataContext.LocationTypes.FindAsync(id);

            if (locationType is null)
                return null;

            return locationType;
        }

        public async Task<Models.LocationType?> UpdateLocationType(int id, Models.LocationType request)
        {
            var locationType = await dataContext.LocationTypes.FindAsync(id);

            if (locationType is null)
                return null;

            locationType.Type = request.Type;

            await dataContext.SaveChangesAsync();

            return locationType;
        }
    }
}
