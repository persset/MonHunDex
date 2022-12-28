using MonHunDex.Data;

namespace MonHunDex.Services.Ailment
{
    public class AilmentService : IAilmentService
    {
        private readonly Data.DataContext dataContext;

        public AilmentService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Models.Ailment> CreateAilment(Models.Ailment ailment)
        {
            dataContext.Ailments.Add(ailment);

            await dataContext.SaveChangesAsync();

            return ailment;
        }

        public async Task<Models.Ailment?> DeleteAilment(int id)
        {
            var ailment = await dataContext.Ailments.FindAsync(id);

            if (ailment is null)
                return null;

            dataContext.Ailments.Remove(ailment);
            await dataContext.SaveChangesAsync();

            return ailment;
        }

        public async Task<List<Models.Ailment>> GetAllAilments()
        {
            return await dataContext.Ailments.ToListAsync();
        }

        public async Task<Models.Ailment?> GetSingleAilment(int id)
        {
            var ailment = await dataContext.Ailments.FindAsync(id);

            if (ailment is null)
                return null;

            return ailment;
        }

        public async Task<Models.Ailment?> UpdateAilment(int id, Models.Ailment request)
        {
            var ailment = await dataContext.Ailments.FindAsync();

            if (ailment is null)
                return null;

            ailment.Name = request.Name;
            ailment.Description = request.Description;

            await dataContext.SaveChangesAsync();

            return ailment;
        }
    }
}
