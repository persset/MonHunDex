namespace MonHunDex.Services.MonsterElement
{
    public interface IMonsterElementService
    {
        Task<List<Models.MonsterElement>> GetAllMonsterElements();
        Task<Models.MonsterElement?> GetSingleMonsterElement(int id);
        Task<Models.MonsterElement> CreateMonsterElement(Models.MonsterElement monsterElement);
        Task<Models.MonsterElement?> UpdateMonsterElement(int id, Models.MonsterElement request);
        Task<Models.MonsterElement?> DeleteMonsterElement(int id);
    }
}
