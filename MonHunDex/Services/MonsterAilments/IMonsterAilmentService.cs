namespace MonHunDex.Services.MonsterAilments
{
    public interface IMonsterAilments
    {
        Task<List<Models.MonsterAilment>> GetAllMonsterAilments();
        Task<Models.MonsterAilment?> GetSingleMonsterAilment(int id);
        Task<Models.MonsterAilment> CreateMonsterAilment(Models.MonsterAilment monsterAilment);
        Task<Models.MonsterAilment?> UpdateMonsterAilment(int id, Models.MonsterAilment request);
        Task<Models.MonsterAilment?> DeleteMonsterAilment(int id);
    }
}
