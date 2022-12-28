namespace MonHunDex.Services.MonsterMove
{
    public interface IMonsterMoveService
    {
        Task<List<Models.MonsterMove>> GetAllMonsterMoves();
        Task<Models.MonsterMove?> GetSingleMonsterMove(int id);
        Task<Models.MonsterMove> CreateMonsterMove(Models.MonsterMove monsterMove);
        Task<Models.MonsterMove?> UpdateMonsterMove(int id, Models.MonsterMove request);
        Task<Models.MonsterMove?> DeleteMonsterMove(int id);
    }
}
