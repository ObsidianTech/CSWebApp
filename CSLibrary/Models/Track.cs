using System;

namespace CSLibrary.Models
{
    public class Track
    {
        public int ID { get; set; }
        public string TrackName { get; set; }
        public string TrackFile { get; set; }
        public string URL { get; set; }
        public int Price { get; set; }
        public DateTime DateOfUpload { get; set; }
        public bool isMP3 { get; set; }
        public bool isWAV { get; set; }
        public bool isStems { get; set; }
        public bool inProject { get; set; }
        public Project ProjectAssigned { get; set; }
        public int TrackNumber { get; set; }
    }
}