namespace MonHunDex.Services.MonsterWeakness
{
    public interface IMonsterWeaknessService
    {
        Task<List<Models.MonsterWeakness>> GetAllMonsterWeaknesses();
        Task<Models.MonsterWeakness?> GetSingleMonsterWeakness(int id);
        Task<Models.MonsterWeakness> CreateMonsterWeakness(Models.MonsterWeakness monsterWeakness);
        Task<Models.MonsterWeakness?> UpdateMonsterWeakness(int id, Models.MonsterWeakness request);
        Task<Models.MonsterWeakness?> DeleteMonsterWeakness(int id);
    }
}
