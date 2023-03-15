using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        #region services 
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        #endregion
        #region Actions based on endpoint url one of these functions will be called 
        public IActionResult Index()
        {//you can write any message here to appeare in console window 
           // _logger.LogInformation("Hello Guys I'm Alyaa Awny a new developer ");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public string HelloDeveloper() {
            _logger.LogInformation("hello message");
            return "hello developer I am Alyaa Awny And I am a newcomer here!"; }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion
    }
}