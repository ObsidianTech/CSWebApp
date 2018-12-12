using System.Collections.Generic;

namespace CSLibrary.Models
{
    public enum ProjectType
    {
        Single,
        Album,
        EP
    }

    public class Project
    {
        public int ID { get; set; }
        public List<Track> TrackList { get; set; }
        public string ProjectName { get; set; }
        public byte[] ConvertedPicture { get; set; }
        public string Picture { get; set; }
        public ProjectType ProjectType { get; set; }
    }
}