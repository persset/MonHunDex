using MonHunDex.Data;

namespace MonHunDex.Services.MonsterTitle
{
    public class MonsterTitleService : IMonsterTitleService
    {
        private readonly DataContext dataContext;

        public MonsterTitleService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.MonsterTitle> CreateMonsterTitle(Models.MonsterTitle monsterTitle)
        {
            dataContext.MonsterTitles.Add(monsterTitle);
            await dataContext.SaveChangesAsync();

            return monsterTitle;
        }

        public async Task<Models.MonsterTitle?> DeleteMonsterTitle(int id)
        {
            var monsterTitle = await dataContext.MonsterTitles.FindAsync(id);

            if (monsterTitle is null)
                return null;

            dataContext.MonsterTitles.Remove(monsterTitle);
            await dataContext.SaveChangesAsync();

            return monsterTitle;
        }

        public async Task<List<Models.MonsterTitle>> GetAllMonsterTitles()
        {
            return await dataContext.MonsterTitles.ToListAsync();
        }

        public async Task<Models.MonsterTitle?> GetSingleMonsterTitle(int id)
        {
            var monsterTitle = await dataContext.MonsterTitles.FindAsync(id);

            if (monsterTitle is null)
                return null;

            return monsterTitle;
        }

        public async Task<Models.MonsterTitle?> UpdateMonsterTitle(int id, Models.MonsterTitle request)
        {
            var monsterTitle = await dataContext.MonsterTitles.FindAsync(id);

            if (monsterTitle is null)
                return null;

            monsterTitle.Title = request.Title;
            monsterTitle.MonsterID = request.MonsterID;

            await dataContext.SaveChangesAsync();

            return monsterTitle;
        }
    }
}
