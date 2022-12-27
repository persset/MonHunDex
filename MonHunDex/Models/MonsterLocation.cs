namespace MonHunDex.Models
{
    public class MonsterLocation
    {
        public int MonsterId { get; set; }
        public Monster Monster { get; set; }
        public int LocationId { get; set; }
        public Location Location {get; set; }
    }
}
