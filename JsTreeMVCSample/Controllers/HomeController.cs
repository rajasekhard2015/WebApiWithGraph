using JsTreeMVCSample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JsTreeMVCSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ActionResult Nodes()
        {
            var nodes = new List<JsTreeModel>();
            nodes.Add(new JsTreeModel() { id = "101", parent = "#", text = "Simple root node" });
            nodes.Add(new JsTreeModel() { id = "102", parent = "#", text = "Root node 1" });
            nodes.Add(new JsTreeModel() { id = "103", parent = "#", text = "Child 1" });
            nodes.Add(new JsTreeModel() { id = "104", parent = "#", text = "Child 2" });
            return Json(nodes);
        }
    }
}
