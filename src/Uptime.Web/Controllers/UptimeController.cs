using Microsoft.AspNetCore.Mvc;
using Uptime.Domain;

namespace Uptime.Controllers
{
    public class UptimeController : Controller
    {
        private readonly IUptimeService _service;

        public UptimeController(IUptimeService service)
        {
            _service = service;
        }
        
        // GET
        public IActionResult Index()
        {
            return Json(_service.Get());
        }
    }
}