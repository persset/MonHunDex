namespace MonHunDex.Models
{
    public class MonsterAilment
    {
        public int MonsterId { get; set; }
        public Monster Monster { get; set; }
        public int AilmentId { get; set; }
        public Ailment Ailment { get; set; }
    }
}
