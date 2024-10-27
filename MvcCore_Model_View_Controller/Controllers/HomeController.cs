using Microsoft.AspNetCore.Mvc;
using MvcCore_Model_View_Controller.Models;
using System.Diagnostics;
using System.Text.Encodings.Web;

namespace MvcCore_Model_View_Controller.Controllers
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {            
            //return BadRequest("Bu isteði gerçekleþtiremezsin.");
            //return Ok("Bu yazý kalýn olacak");
            return View();
        }

        [Route("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
