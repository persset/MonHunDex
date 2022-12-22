namespace MonHunDex.Models
{
    public class MonsterLocation
    {
        public int ID { get; set; }
        public int MonsterID { get; set; }
        public int LocationID { get; set; }

        public virtual Monster Monster { get; set; }
        public virtual Location Location { get; set; }
    }
}
