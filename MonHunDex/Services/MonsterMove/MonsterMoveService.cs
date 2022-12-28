using MonHunDex.Data;

namespace MonHunDex.Services.MonsterMove
{
    public class MonsterMoveService : IMonsterMoveService
    {
        private readonly DataContext dataContext;

        public MonsterMoveService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.MonsterMove> CreateMonsterMove(Models.MonsterMove monsterMove)
        {
            dataContext.MonsterMoves.Add(monsterMove);
            await dataContext.SaveChangesAsync();

            return monsterMove;
        }

        public async Task<Models.MonsterMove?> DeleteMonsterMove(int id)
        {
            var monsterMove = await dataContext.MonsterMoves.FindAsync(id);

            if (monsterMove is null)
                return null;

            dataContext.MonsterMoves.Remove(monsterMove);
            await dataContext.SaveChangesAsync();

            return monsterMove;
        }

        public async Task<List<Models.MonsterMove>> GetAllMonsterMoves()
        {
            return await dataContext.MonsterMoves.ToListAsync();
        }

        public async Task<Models.MonsterMove?> GetSingleMonsterMove(int id)
        {
            var monsterMove = await dataContext.MonsterMoves.FindAsync(id);

            if (monsterMove is null)
                return null;

            return monsterMove;
        }

        public async Task<Models.MonsterMove?> UpdateMonsterMove(int id, Models.MonsterMove request)
        {
            var monsterMove = await dataContext.MonsterMoves.FindAsync(id);

            if (monsterMove is null)
                return null;

            monsterMove.MonsterId = request.MonsterId;
            monsterMove.MoveId = request.MoveId;

            await dataContext.SaveChangesAsync();

            return monsterMove;
        }
    }
}
