namespace MonHunDex.Services.MonsterTitle
{
    public interface IMonsterTitleService
    {
        Task<List<Models.MonsterTitle>> GetAllMonsterTitles();
        Task<Models.MonsterTitle?> GetSingleMonsterTitle(int id);
        Task<Models.MonsterTitle> CreateMonsterTitle(Models.MonsterTitle monsterTitle);
        Task<Models.MonsterTitle?> UpdateMonsterTitle(int id, Models.MonsterTitle request);
        Task<Models.MonsterTitle?> DeleteMonsterTitle(int id);
    }
}
