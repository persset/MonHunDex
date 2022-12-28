namespace MonHunDex.Services.LocationType
{
    public interface ILocationTypeService
    {
        Task<List<Models.LocationType>> GetAllLocationTypes();
        Task<Models.LocationType?> GetSingleLocationType(int id);
        Task<Models.LocationType> CreateLocationType(Models.LocationType locationType);
        Task<Models.LocationType?> UpdateLocationType(int id, Models.LocationType request);
        Task<Models.LocationType?> DeleteLocationType(int id);
    }
}
