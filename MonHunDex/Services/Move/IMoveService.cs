namespace MonHunDex.Services.Move
{
    public interface IMoveService
    {
        Task<List<Models.Move>> GetAllMoves();
        Task<Models.Move?> GetSingleMove(int id);
        Task<Models.Move> CreateMove(Models.Move move);
        Task<Models.Move?> UpdateMove(int id, Models.Move request);
        Task<Models.Move?> DeleteMove(int id);
    }
}
