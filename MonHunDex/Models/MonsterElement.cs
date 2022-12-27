namespace MonHunDex.Models
{
    public class MonsterElement
    {
        public int MonsterId { get; set; }
        public int ElementId { get; set; }
        public Monster Monster { get; set; }
        public Element Element { get; set; }

    }
}
