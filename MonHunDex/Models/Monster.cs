namespace MonHunDex.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Physiology { get; set; } = string.Empty;
        public string IconUrl { get; set; } = string.Empty;
        public int BehaviorId { get; set; }
        public Behavior? Behavior { get; set; }
        public int MonsterClassId { get; set; }
        public MonsterClass? MonsterClass { get; set; }
        public ICollection<MonsterLocation>? MonsterLocations { get; set; }
        public ICollection<MonsterElement>? MonsterElements { get; set; }
        public ICollection<MonsterAilment>? MonsterAilments { get; set; }
        public ICollection<MonsterMove>? MonsterMoves { get; set; }
        public ICollection<MonsterWeakness>? MonsterWeaknesses { get; set; }
    }
}
