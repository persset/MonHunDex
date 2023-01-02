namespace MonHunDex.Models
{
    public class Ailment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<MonsterAilment>? MonsterAilments { get; set; }
    }
}
