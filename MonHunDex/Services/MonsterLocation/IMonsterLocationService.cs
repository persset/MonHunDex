namespace MonHunDex.Services.MonsterLocation
{
    public interface IMonsterLocationService
    {
        Task<List<Models.MonsterLocation>> GetAllMonsterLocations();
        Task<Models.MonsterLocation?> GetSingleMonsterLocation(int id);
        Task<Models.MonsterLocation> CreateMonsterLocation(Models.MonsterLocation monsterLocation);
        Task<Models.MonsterLocation?> UpdateMonsterLocation(int id, Models.MonsterLocation request);
        Task<Models.MonsterLocation?> DeleteMonsterLocation(int id);
    }
}
