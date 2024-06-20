using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContactManagerStarter.Controllers
{
    public class HomeController : Controller
    {   //Logger added to Home
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("About page visited at {DT}", DateTime.UtcNow.ToLongTimeString());

            return View();
        }
    }
}
