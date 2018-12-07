using CSLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using System.Linq;

namespace CSLibrary.Managers
{
    public class ProjectManager
    {
        public ApplicationDbContext _context { get; set; }
        public IHostingEnvironment _env { get; set; }

        public ProjectManager (ApplicationDbContext context, IHostingEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public List<Project> GetProjects()
        {
            List<Project> Projects = _context.Projects.ToList();
            return Projects;
        }
    }
}
