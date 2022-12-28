using MonHunDex.Data;

namespace MonHunDex.Services.Behavior
{
    public class BehaviorService : IBehaviorService
    {
        private readonly Data.DataContext dataContext;

        public BehaviorService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Behavior> CreateBehavior(Models.Behavior behavior)
        {
            dataContext.Behaviors.Add(behavior);

            await dataContext.SaveChangesAsync();

            return behavior;
        }

        public async Task<Models.Behavior?> DeleteBehavior(int id)
        {
            var behavior = await dataContext.Behaviors.FindAsync(id);

            if (behavior is null)
                return null;

            dataContext.Behaviors.Remove(behavior);
            await dataContext.SaveChangesAsync();

            return behavior;
        }

        public async Task<List<Models.Behavior>> GetAllBehaviors()
        {
            return await dataContext.Behaviors.ToListAsync();
        }

        public async Task<Models.Behavior?> GetSingleBehavior(int id)
        {
            var behavior = await dataContext.Behaviors.FindAsync(id);

            if (behavior is null)
                return null;

            return behavior;
        }

        public async Task<Models.Behavior?> UpdateBehavior(int id, Models.Behavior request)
        {
            var behavior = await dataContext.Behaviors.FindAsync(id);

            if (behavior is null)
                return null;

            behavior.Name = request.Name;
            behavior.Description = request.Description;

            await dataContext.SaveChangesAsync();

            return behavior;
        }
    }
}
