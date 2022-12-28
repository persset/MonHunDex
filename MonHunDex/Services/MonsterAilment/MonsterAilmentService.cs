using MonHunDex.Data;
using MonHunDex.Models;

namespace MonHunDex.Services.MonsterAilments
{
    public class MonsterAilmentService : IMonsterAilmentService
    {
        private readonly DataContext dataContext;

        public MonsterAilmentService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<MonsterAilment> CreateMonsterAilment(MonsterAilment monsterAilment)
        {
            dataContext.MonsterAilments.Add(monsterAilment);
            await dataContext.SaveChangesAsync();

            return monsterAilment;
        }

        public async Task<MonsterAilment?> DeleteMonsterAilment(int id)
        {
            var monsterAilment = await dataContext.MonsterAilments.FindAsync(id);

            if (monsterAilment is null)
                return null;

            dataContext.MonsterAilments.Remove(monsterAilment);
            await dataContext.SaveChangesAsync();

            return monsterAilment;
        }

        public async Task<List<MonsterAilment>> GetAllMonsterAilments()
        {
            return await dataContext.MonsterAilments.ToListAsync();
        }

        public async Task<MonsterAilment?> GetSingleMonsterAilment(int id)
        {
            var monsterAilment = await dataContext.MonsterAilments.FindAsync(id);

            if (monsterAilment is null)
                return null;

            return monsterAilment;
        }

        public async Task<MonsterAilment?> UpdateMonsterAilment(int id, MonsterAilment request)
        {
            var monsterAilment = await dataContext.MonsterAilments.FindAsync(id);

            if (monsterAilment is null)
                return null;

            monsterAilment.MonsterId = request.MonsterId;
            monsterAilment.AilmentId = request.AilmentId;

            await dataContext.SaveChangesAsync();

            return monsterAilment;
        }
    }
}
