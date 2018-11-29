using CSLibrary.Models;
using CSLibrary.Models.DTOs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CSLibrary.Managers
{
    public class TrackManager
    {
        public ApplicationDbContext _context { get; set; }
        public IHostingEnvironment _env { get; set; }
        public string _uploadPath { get; set; }

        public TrackManager(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            _uploadPath = Path.Combine(_env.WebRootPath, "Tracks");

        }

        public async Task<TrackUploadResponseDTO> AddNewTrack(IFormFile track)
        {
            var newTrack = new Track();
            Directory.CreateDirectory(Path.Combine(_uploadPath, track.FileName));
            string filename = Path.GetFileName(track.FileName);
            using (FileStream fs = new FileStream(Path.Combine(_uploadPath, track.FileName, filename), FileMode.Create))
            {
               await track.CopyToAsync(fs);
            }
            newTrack.DateOfUpload = DateTime.Now;
            newTrack.isMP3 = true;
            newTrack.TrackFile = track.FileName;
            await _context.Tracks.AddAsync(newTrack);
            await _context.SaveChangesAsync();
            var response = new TrackUploadResponseDTO()
            {
                //name = Track.FileName,
                //size = Track.Length,
                //url = 
            };
            return response;
        }
    }
}
