using System.Collections.Generic;

namespace MdevconUniversal.Common.Domain
{
    public class Room
    {
        public string name { get; set; }
        public List<Beacon> beacons { get; set; }
    }
}