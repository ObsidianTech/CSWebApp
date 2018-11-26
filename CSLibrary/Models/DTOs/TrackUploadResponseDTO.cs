using System;
using System.Collections.Generic;
using System.Text;

namespace CSLibrary.Models.DTOs
{
    public class TrackUploadResponseDTO
    {
        public string name { get; set; }
        public double size { get; set; }
        public string url { get; set; }
        public string thumbnailurl { get; set; }
        public string deleteurl { get; set; }
        public string deletetype { get; set; }
    }
}
