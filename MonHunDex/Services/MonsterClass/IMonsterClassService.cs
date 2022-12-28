namespace MonHunDex.Services.MonsterClass
{
    public interface IMonsterClassService
    {
        Task<List<Models.MonsterClass>> GetAllMonsterClasses();
        Task<Models.MonsterClass?> GetSingleMonsterClass(int id);
        Task<Models.MonsterClass> CreateMonsterClass(Models.MonsterClass monsterClass);
        Task<Models.MonsterClass?> UpdateMonsterClass(int id, Models.MonsterClass request);
        Task<Models.MonsterClass?> DeleteMonsterClass(int id);
    }
}
