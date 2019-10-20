using Microsoft.AspNetCore.Mvc;
using MyFirstCoreApp.src.MyConsoleLogger;

namespace MyFirstCoreApp.src.Controllers
{
    public class HomeController : Controller 
    {
        private ILog _log;
        public HomeController(ILog log)
        {
            _log = log;
        }

        public IActionResult Index([FromServices] ILog log)
        {
            _log.info("Index method executing");

            return View();
        }
    }
}