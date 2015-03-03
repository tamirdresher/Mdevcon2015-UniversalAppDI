using System.Collections.Generic;

namespace MdevconUniversal.Common.Domain
{
    public class RootObject
    {
        public string eventName { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string apiEndpoint { get; set; }
        public string joindInApiEndpoint { get; set; }
        public int joindInId { get; set; }
        public string welcomeText { get; set; }
        public Dictionary<string,Location> locations { get; set; }
        public Dictionary<string,Track> tracks { get; set; }
        public string practicalInfo { get; set; }
        public string description { get; set; }
    }
}