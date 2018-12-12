using CSLibrary.Models;
using System.Collections.Generic;

namespace CSLibrary.Models
{
    public class HomeViewModel
    {
        public List<Track> TrackPool { get; set; }
        public List<Project> Projects { get; set; }
        public List<Track> SelectedTracks { get; set; }
        public Project ProjectToEdit { get; set; }
        public List<Track> UnallocatedTracks { get; set; }
    }
}