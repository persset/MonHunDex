namespace MonHunDex.Models
{
    public class MonsterMove
    {
        public int MonsterId { get; set; }
        public int MoveId { get; set; }
        public Monster Monster { get; set; }
        public Move Move { get; set; }
    }
}
