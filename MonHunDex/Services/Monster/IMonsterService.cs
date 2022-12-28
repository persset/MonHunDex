using MonHunDex.Models;
namespace MonHunDex.Services.Monster
{
    public interface IMonsterService
    {
        Task<List<Models.Monster>> GetAllMonsters();
        Task<Models.Monster?> GetSingleMonster(int id);
        Task<Models.Monster> CreateMonster(Models.Monster monster);
        Task<Models.Monster?> UpdateMonster(int id, Models.Monster request);
        Task<Models.Monster?> DeleteMonster(int id);
    }
}
