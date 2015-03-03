using System;
using System.Collections.Generic;
using MdevconUniversal.Common.Managers;

namespace MdevconUniversal.Common.Domain
{
    public class Lecture    
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime StartTime { get; set; }
        public string Description { get; set; }
        public IEnumerable<LectureSpeaker> Speakers { get; set; }
        public TimeSpan Duration { get; set; }
    }
}