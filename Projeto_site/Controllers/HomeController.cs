using Microsoft.AspNetCore.Mvc;
using Projeto_site.Models;
using System.Diagnostics;

namespace Projeto_site.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dev()
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
