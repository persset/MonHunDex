namespace MonHunDex.Models
{
    public class MonsterTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MonsterID { get; set; }
        public Monster Monster { get; set; }
    }
}
