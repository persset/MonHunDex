namespace MonHunDex.Models
{
    public class LocationType
    {
        public int Id { get; set; }
        public string Type { get; set; } = string.Empty;
        public ICollection<Location>? Locations { get; set; }
    }
}
