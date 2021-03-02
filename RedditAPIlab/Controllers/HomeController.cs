using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RedditAPIlab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPIlab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private PoorDAL psr = new PoorDAL();
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            PoorSubRoot p = psr.ConvertToPoor("aww");
            List<Child> basePath = p.data.children;
           
            List<TrimmedPoorSub> tps = new List<TrimmedPoorSub>();

            foreach(Child c in basePath)
            {
                tps.Add(new TrimmedPoorSub(c.data.title,c.data.thumbnail,"https://www.reddit.com" + c.data.permalink));
            }

            return View(tps);
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
    }
}
