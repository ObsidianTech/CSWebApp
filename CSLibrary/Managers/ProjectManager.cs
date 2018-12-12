using CSLibrary.Models;
using CSLibrary.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace CSLibrary.Managers
{
    public class ProjectManager
    {
        public ApplicationDbContext _context { get; set; }
        public IHostingEnvironment _env { get; set; }
        public string _uploadPath { get; set; }

        public ProjectManager(ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
            _uploadPath = Path.Combine(_env.WebRootPath, "Projects");

        }

        public List<Project> GetProjects()
        {
            List<Project> Projects = _context.Projects.ToList();
            return Projects;
        }

        public async Task<ProjectCreationResponseDTO> CreateNewProjectAsync(string name, ProjectType projectType, IFormFile picture)
        {
            var newProject = new Project();
            Directory.CreateDirectory(Path.Combine(_uploadPath, picture.FileName));
            string filename = Path.GetFileName(picture.FileName);
            using (FileStream fs = new FileStream(Path.Combine(_uploadPath, picture.FileName, filename), FileMode.Create))
            {
                await picture.CopyToAsync(fs);
            }
            newProject.ProjectName = name;
            newProject.ProjectType = projectType;
            newProject.Picture = picture.FileName;
            await _context.Projects.AddAsync(newProject);
            await _context.SaveChangesAsync();
            var response = new ProjectCreationResponseDTO()
            {
                name = name,
                Picture = picture
            };
            return response;
        }

        public Project GetProjects(int iD)
        {
            return _context.Projects.Where(p => p.ID == iD).FirstOrDefault();
        }
    }
}
