namespace MonHunDex.Models
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<MonsterElement> MonsterElements { get; set; }
        public ICollection<MonsterWeakness> MonsterWeaknesses { get; set; }
    }
}
