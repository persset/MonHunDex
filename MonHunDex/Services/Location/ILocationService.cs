namespace MonHunDex.Services.Location
{
    public interface ILocationService
    {
        Task<List<Models.Location>> GetAllLocations();
        Task<Models.Location?> GetSingleLocation(int id);
        Task<Models.Location> CreateLocation(Models.Location location);
        Task<Models.Location?> UpdateLocation(int id, Models.Location request);
        Task<Models.Location?> DeleteLocation(int id);
    }
}
