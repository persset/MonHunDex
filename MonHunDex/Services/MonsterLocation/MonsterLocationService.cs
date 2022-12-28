using MonHunDex.Data;

namespace MonHunDex.Services.MonsterLocation
{
    public class MonsterLocationService : IMonsterLocationService
    {
        private readonly DataContext dataContext;

        public MonsterLocationService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.MonsterLocation> CreateMonsterLocation(Models.MonsterLocation monsterLocation)
        {
            dataContext.MonsterLocations.Add(monsterLocation);
            await dataContext.SaveChangesAsync();

            return monsterLocation;
        }

        public async Task<Models.MonsterLocation?> DeleteMonsterLocation(int id)
        {
            var monsterLocation = await dataContext.MonsterLocations.FindAsync(id);

            if (monsterLocation is null)
                return null;

            dataContext.MonsterLocations.Remove(monsterLocation);
            await dataContext.SaveChangesAsync();

            return monsterLocation;
        }

        public async Task<List<Models.MonsterLocation>> GetAllMonsterLocations()
        {
            return await dataContext.MonsterLocations.ToListAsync();
        }

        public async Task<Models.MonsterLocation?> GetSingleMonsterLocation(int id)
        {
            var monsterLocation = await dataContext.MonsterLocations.FindAsync(id);

            if (monsterLocation is null)
                return null;

            return monsterLocation;
        }

        public async Task<Models.MonsterLocation?> UpdateMonsterLocation(int id, Models.MonsterLocation request)
        {
            var monsterLocation = await dataContext.MonsterLocations.FindAsync(id);

            if (monsterLocation is null)
                return null;

            monsterLocation.LocationId = request.LocationId;
            monsterLocation.MonsterId = request.MonsterId;

            await dataContext.SaveChangesAsync();

            return monsterLocation;
        }
    }
}
