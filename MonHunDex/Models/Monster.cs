namespace MonHunDex.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Physiology { get; set; } = string.Empty;
        public int BehaviorId { get; set; }
        public Behavior Behavior { get; set; }
        public ICollection<MonsterLocation> MonsterLocations { get; set; }
        public ICollection<MonsterElement> MonsterElements { get; set; }
        public ICollection<MonsterAilment> MonsterAilments { get; set; }
    }
}
