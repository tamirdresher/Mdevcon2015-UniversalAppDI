using System.Collections.Generic;

namespace MdevconUniversal.Common.Domain
{
    public class Location
    {
        public string id { get; set; }
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Dictionary<string,Room> rooms { get; set; }
    }
}