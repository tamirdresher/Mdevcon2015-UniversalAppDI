using System.Collections.Generic;

namespace MdevconUniversal.Common.Domain
{
    public class Track
    {
        public string name { get; set; }
        public string location { get; set; }
        public string room { get; set; }
        public string date { get; set; }
        public int sort { get; set; }
        public List<Session> sessions { get; set; }
    }
}