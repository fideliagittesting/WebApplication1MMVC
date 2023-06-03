using Microsoft.AspNetCore.Mvc;

namespace WebApplication1MMVC.Controllers
{
    public class HistoryController1 : Controller
    {
        private readonly ILogger<HistoryController1> _logger;

        public HistoryController1(ILogger<HistoryController1> logger)
        {
            _logger = logger;
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        
    }
}
