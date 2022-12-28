using MonHunDex.Data;
using MonHunDex.Models;

namespace MonHunDex.Services.MonsterWeakness
{
    public class MonsterWeaknessService : IMonsterWeaknessService
    {
        private readonly DataContext dataContext;

        public MonsterWeaknessService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.MonsterWeakness> CreateMonsterWeakness(Models.MonsterWeakness monsterWeakness)
        {
            dataContext.MonsterWeaknesses.Add(monsterWeakness);
            await dataContext.SaveChangesAsync();

            return monsterWeakness;
        }

        public async Task<Models.MonsterWeakness?> DeleteMonsterWeakness(int id)
        {
            var monsterWeakness = await dataContext.MonsterWeaknesses.FindAsync(id);

            if (monsterWeakness is null)
                return null;

            dataContext.MonsterWeaknesses.Remove(monsterWeakness);
            await dataContext.SaveChangesAsync();

            return monsterWeakness;
        }

        public async Task<List<Models.MonsterWeakness>> GetAllMonsterWeaknesses()
        {
            return await dataContext.MonsterWeaknesses.ToListAsync();
        }

        public async Task<Models.MonsterWeakness?> GetSingleMonsterWeakness(int id)
        {
            var monsterWeakness = await dataContext.MonsterWeaknesses.FindAsync(id);

            if (monsterWeakness is null)
                return null;

            return monsterWeakness;
        }

        public async Task<Models.MonsterWeakness?> UpdateMonsterWeakness(int id, Models.MonsterWeakness request)
        {
            var monsterWeakness = await dataContext.MonsterWeaknesses.FindAsync(id);

            if (monsterWeakness is null)
                return null;

            monsterWeakness.ElementId = request.ElementId;
            monsterWeakness.MonsterId = request.MonsterId;

            await dataContext.SaveChangesAsync();

            return monsterWeakness;
        }
    }
}
