﻿using System;
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
        public ProjectManager _projectManager { get; set; }

        public v1(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            _trackManager = new TrackManager(_context, _env);
            _projectManager = new ProjectManager(_context, _env);
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        [Route("UploadTrack")]
        public async Task<string> UploadTrack(IFormFile Track) => JsonConvert.SerializeObject(await _trackManager.AddNewTrack(Track));

        [HttpGet]
        [Route("GetTrackPool")]
        public List<Track> GetTrackPool()
        {
            return _trackManager.GetTrackPool();
        }

        [HttpPost]
        [Route("UploadTrackFromWeb")]
        public async Task<IActionResult> UploadTrackFromWeb(IFormFile Track)
        {
            var response = await _trackManager.AddNewTrack(Track);
            return RedirectToAction("TrackInfo", "Home", response);
        }

        [HttpPost]
        [Route("TrackInfoFromWeb")]
        public IActionResult TrackInfoFromWeb(string TrackName, string Price, int TrackID)
        {
            _trackManager.UpdateTrackInfo(TrackName, Price, TrackID);
            return RedirectToAction("Admin", "Home");
        }

        public List<Project> GetProjects() => _projectManager.GetProjects();

        [HttpPost]
        [Route("CreateProject")]
        public async Task<IActionResult> CreateProjectAsync(string Name, ProjectType ProjectType, IFormFile Picture)
        {
            var response = await _projectManager.CreateNewProjectAsync(Name, ProjectType, Picture);
            return RedirectToAction("Admin", "Home");
        }

        [HttpGet]
        public Project GetProject(int ID)
        {
            return _projectManager.GetProjects(ID);
        }
    }
}
