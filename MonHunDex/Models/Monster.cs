namespace MonHunDex.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Physiology { get; set; } = string.Empty;
        public string Behavior { get; set; } = string.Empty;
        public virtual ICollection<MonsterLocation> MonsterLocations { get; set; }
    }
}
