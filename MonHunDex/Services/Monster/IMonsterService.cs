using MonHunDex.Models;
namespace MonHunDex.Services.Monster
{
    public interface IMonsterService
    {
        Task<List<Models.Monster>> GetAllMonster();
        Task<Models.Monster?> GetSingleMonster();
        Task<List<Models.Monster>> CreateMonster(Models.Monster monster);
        Task<List<Models.Monster>> UpdateMonster(int id, Models.Monster monster);
        Task<List<Models.Monster>> DeleteMonster(int id);
    }
}
