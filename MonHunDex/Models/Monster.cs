namespace MonHunDex.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public string Physiology { get; set; } = String.Empty;
        public string Behavior { get; set; } = String.Empty;
    }
}
