using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSLibrary.Managers;
using CSLibrary.Models;
using CSLibrary.Models.DTOs;
using Microsoft.AspNetCore.Hosting;
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
        public TrackManager _trackManager { get; set; }
        public IHostingEnvironment _env { get; set; }


        public v1(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            _trackManager = new TrackManager(_context, _env);
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("UploadTrack")]
        public async Task<string> UploadTrack(IFormFile Track)
        {
            
            return JsonConvert.SerializeObject( await _trackManager.AddNewTrack(Track));
        }
    }
}
