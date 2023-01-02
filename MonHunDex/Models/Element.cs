namespace MonHunDex.Models
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<MonsterElement>? MonsterElements { get; set; }
        public ICollection<MonsterWeakness>? MonsterWeaknesses { get; set; }
    }
}
