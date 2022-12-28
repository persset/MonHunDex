namespace MonHunDex.Services.Behavior
{
    public interface IBehaviorService
    {
        Task<List<Models.Behavior>> GetAllBehaviors();
        Task<Models.Behavior?> GetSingleBehavior(int id);
        Task<Models.Behavior> CreateBehavior(Models.Behavior behavior);
        Task<Models.Behavior?> UpdateBehavior(int id, Models.Behavior request);
        Task<Models.Behavior?> DeleteBehavior(int id);
    }
}
