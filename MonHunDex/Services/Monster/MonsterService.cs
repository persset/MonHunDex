using MonHunDex.Data;

namespace MonHunDex.Services.Monster
{
    public class MonsterService : IMonsterService
    {
        private readonly Data.DataContext dataContext;

        public MonsterService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        async Task<Models.Monster> IMonsterService.CreateMonster(Models.Monster monster)
        {
            dataContext.Monsters.Add(monster);
            
            var id = await dataContext.SaveChangesAsync();

            return monster;
        }

        async Task<Models.Monster> IMonsterService.DeleteMonster(int id)
        {
            var monster = await dataContext.Monsters.FindAsync(id);
            
            if (monster is null)
                return null;

            dataContext.Monsters.Remove(monster);
            await dataContext.SaveChangesAsync();

            return monster;
        }

        async Task<List<Models.Monster>> IMonsterService.GetAllMonsters()
        {
            return await dataContext.Monsters.ToListAsync();
        }

        async Task<Models.Monster?> IMonsterService.GetSingleMonster(int id)
        {
            var monster = await dataContext.Monsters.FindAsync(id);
            if (monster is null)
                return null;

            return monster;
        }

        async Task<Models.Monster> IMonsterService.UpdateMonster(int id, Models.Monster request)
        {
            var monster = await dataContext.Monsters.FindAsync(id);

            if (monster is null)
                return null;

            monster.Name = request.Name;
            monster.Description = request.Description;
            monster.Physiology = request.Physiology;
            monster.BehaviorId = request.BehaviorId;
            monster.MonsterClassId = request.MonsterClassId;
            
            await dataContext.SaveChangesAsync();

            return monster;
        }
    }
}
