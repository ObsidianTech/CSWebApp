using System;

namespace CSLibrary.Models
{
    public class Track
    {
        public int ID { get; set; }
        public string TrackName { get; set; }
        public byte[] TrackFile { get; set; }
        public int Price { get; set; }
        public DateTime DateOfUpload { get; set; }
        public bool isMP3 { get; set; }
        public bool isWAV { get; set; }
        public bool isStems { get; set; }
    }
}