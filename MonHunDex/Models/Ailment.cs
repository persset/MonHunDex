namespace MonHunDex.Models
{
    public class Ailment
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string Description { get; set; }
        public ICollection<MonsterAilment> MonsterAilments { get; set; }
    }
}
