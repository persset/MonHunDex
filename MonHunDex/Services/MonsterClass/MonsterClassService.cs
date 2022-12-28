using MonHunDex.Data;

namespace MonHunDex.Services.MonsterClass
{
    public class MonsterClassService : IMonsterClassService
    {
        private readonly DataContext dataContext;

        public MonsterClassService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.MonsterClass> CreateMonsterClass(Models.MonsterClass monsterClass)
        {
            dataContext.MonsterClasses.Add(monsterClass);
            await dataContext.SaveChangesAsync();

            return monsterClass;
        }

        public async Task<Models.MonsterClass?> DeleteMonsterClass(int id)
        {
            var monsterClass = await dataContext.MonsterClasses.FindAsync(id);

            if (monsterClass is null)
                return null;

            dataContext.MonsterClasses.Remove(monsterClass);
            await dataContext.SaveChangesAsync();

            return monsterClass;
        }

        public async Task<List<Models.MonsterClass>> GetAllMonsterClasses()
        {
            return await dataContext.MonsterClasses.ToListAsync();
        }

        public async Task<Models.MonsterClass?> GetSingleMonsterClass(int id)
        {
            var monsterClass = await dataContext.MonsterClasses.FindAsync(id);

            if (monsterClass is null)
                return null;

            return monsterClass;
        }

        public async Task<Models.MonsterClass?> UpdateMonsterClass(int id, Models.MonsterClass request)
        {
            var monsterClass = await dataContext.MonsterClasses.FindAsync(id);

            if (monsterClass is null)
                return null;

            monsterClass.Name = request.Name;
            monsterClass.Description = request.Description;

            await dataContext.SaveChangesAsync();

            return monsterClass;
        }
    }
}
