using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSLibrary.Models;
using CSLibrary.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSWebApp.Controllers
{

    [Route("api/[controller]")]
    public class v1 : Controller
    {
        public ApplicationDbContext _context { get; set; }
        public JsonSerializer _serializer { get; set; }


        public v1(ApplicationDbContext context)
        {
            _context = context;
            _serializer = new JsonSerializer();
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("UploadTrack")]
        public async Task<TrackUploadResponseDTO> UploadTrack(IFormFile Track)
        {
            var response = new TrackUploadResponseDTO()
            {
                name = Track.FileName,
                size = Track.Length,
                url = 
            };
            return response;
        }
    }
}
