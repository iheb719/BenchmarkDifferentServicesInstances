using BenchmarkTransientServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace BenchmarkTransientServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DummyController : ControllerBase
    {
        private readonly UtilityService _utilityService;

        public DummyController(UtilityService utilityService)
        {
            _utilityService = utilityService;
        }

        [HttpGet]
        public int Get()
        {
            return _utilityService.UtilityMethod();
        }
    }
}