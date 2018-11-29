using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSLibrary.Models;
using Microsoft.AspNetCore.Hosting;

namespace CSWebApp.Controllers
{
    public class HomeController : Controller
    {
        public v1 _v1 { get; set; }
        public HomeViewModel HVM { get; set; }

        public HomeController(ApplicationDbContext context, IHostingEnvironment env)
        {
            _v1 = new v1(context, env);
            HVM = new HomeViewModel();

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}
