namespace MonHunDex.Models
{
    public class LocationType
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;

        public virtual ICollection<Location> Locations { get; set; } = new List<Location>();
    }
}
