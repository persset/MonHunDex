﻿namespace MonHunDex.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Geography { get; set; } = string.Empty;
        public int LocationTypeId { get; set; }
        public LocationType LocationType { get; set; } = new LocationType();
        public ICollection<MonsterLocation>? MonsterLocations { get; set; }
    }
}
