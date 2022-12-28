using MonHunDex.Data;
using MonHunDex.Models;

namespace MonHunDex.Services.MonsterElement
{
    public class MonsterElementService : IMonsterElementService
    {
        private readonly DataContext dataContext;

        public MonsterElementService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.MonsterElement> CreateMonsterElement(Models.MonsterElement monsterElement)
        {
            dataContext.MonsterElements.Add(monsterElement);
            await dataContext.SaveChangesAsync();

            return monsterElement;
        }

        public async Task<Models.MonsterElement?> DeleteMonsterElement(int id)
        {
            var monsterElement = await dataContext.MonsterElements.FindAsync(id);

            if (monsterElement is null)
                return null;

            dataContext.MonsterElements.Remove(monsterElement);
            await dataContext.SaveChangesAsync();

            return monsterElement;
        }

        public async Task<List<Models.MonsterElement>> GetAllMonsterElements()
        {
            return await dataContext.MonsterElements.ToListAsync();
        }

        public async Task<Models.MonsterElement?> GetSingleMonsterElement(int id)
        {
            var monsterElement = await dataContext.MonsterElements.FindAsync(id);

            if (monsterElement is null)
                return null;

            return monsterElement;
        }

        public async Task<Models.MonsterElement?> UpdateMonsterElement(int id, Models.MonsterElement request)
        {
            var monsterElement = await dataContext.MonsterElements.FindAsync(id);

            if (monsterElement is null)
                return null;

            monsterElement.ElementId = request.ElementId;
            monsterElement.MonsterId = request.ElementId;

            await dataContext.SaveChangesAsync();

            return monsterElement;
        }
    }
}
