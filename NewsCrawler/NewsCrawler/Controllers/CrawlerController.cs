using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NewsCrawler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrawlerController : ControllerBase
    {
        private readonly ILogger<CrawlerController> _logger;

        public CrawlerController(ILogger<CrawlerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return new JsonResult("Welcome to news crawler");
        }
    }
}
