namespace MonHunDex.Services.Ailment
{
    public interface IAilmentService
    {
        Task<List<Models.Ailment>> GetAllAilments();
        Task<Models.Ailment?> GetSingleAilment(int id);
        Task<Models.Ailment> CreateAilment(Models.Ailment ailment);
        Task<Models.Ailment?> UpdateAilment(int id, Models.Ailment request);
        Task<Models.Ailment?> DeleteAilment(int id);
    }
}
