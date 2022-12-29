using MonHunDex.Data;

namespace MonHunDex.Services.Move
{
    public class MoveService : IMoveService
    {
        private readonly DataContext dataContext;

        public MoveService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Move> CreateMove(Models.Move move)
        {
            dataContext.Moves.Add(move);
            await dataContext.SaveChangesAsync();

            return move;
        }

        public async Task<Models.Move?> DeleteMove(int id)
        {
            var move = await dataContext.Moves.FindAsync(id);

            if (move is null)
                return null;

            dataContext.Moves.Remove(move);
            await dataContext.SaveChangesAsync();

            return move;
        }

        public async Task<List<Models.Move>> GetAllMoves()
        {
            return await dataContext.Moves.ToListAsync();
        }

        public async Task<Models.Move?> GetSingleMove(int id)
        {
            var move = await dataContext.Moves.FindAsync(id);

            if (move is null)
                return null;

            return move;
        }

        public async Task<Models.Move?> UpdateMove(int id, Models.Move request)
        {
            var move = await dataContext.Moves.FindAsync(id);

            if (move is null)
                return null;

            move.Name = request.Name;
            move.Description = request.Description;

            await dataContext.SaveChangesAsync();

            return move;
        }
    }
}
