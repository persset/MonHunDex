namespace MonHunDex.Models
{
    public class Move
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public ICollection<MonsterMove> MonsterMoves { get; set; }
    }
}
