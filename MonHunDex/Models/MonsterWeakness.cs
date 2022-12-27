namespace MonHunDex.Models
{
    public class MonsterWeakness
    {
        public int MonsterId { get; set; }
        public Monster Monster { get; set; }
        public int ElementId { get; set; }
        public Element Element { get; set; }
    }
}
