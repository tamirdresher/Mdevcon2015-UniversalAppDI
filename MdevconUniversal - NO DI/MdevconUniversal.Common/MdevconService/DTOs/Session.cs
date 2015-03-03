using System.Collections.Generic;

namespace MdevconUniversal.Common.Domain
{
    public class Session
    {
        public string talkTitle { get; set; }
        public string urlFriendlyTalkTitle { get; set; }
        public string talkDescription { get; set; }
        public string type { get; set; }
        public string startDate { get; set; }
        public int duration { get; set; }
        public string stub { get; set; }
        public int averageRating { get; set; }
        public int commentsEnabled { get; set; }
        public int commentCount { get; set; }
        public bool starred { get; set; }
        public int starredCount { get; set; }
        public List<Speaker> speakers { get; set; }
        public string uri { get; set; }
        public string verboseUri { get; set; }
        public string websiteUri { get; set; }
        public string commentsUri { get; set; }
        public string starredUri { get; set; }
        public string verboseCommentsUri { get; set; }
        public string eventUri { get; set; }
        public List<object> platforms { get; set; }
    }
}