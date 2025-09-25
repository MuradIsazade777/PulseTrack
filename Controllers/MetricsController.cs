using Microsoft.AspNetCore.Mvc;
using PulseTrack.Models;
using PulseTrack.Services;

namespace PulseTrack.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MetricsController : ControllerBase
    {
        private readonly MetricsService _service;

        public MetricsController(MetricsService service)
        {
            _service = service;
        }

        [HttpPost("heartrate")]
        public IActionResult AddHeartRate([FromBody] HeartRate hr)
        {
            _service.AddHeartRate(hr);
            return Ok();
        }

        [HttpGet("heartrate")]
        public IActionResult GetHeartRates()
        {
            var data = _service.GetAllHeartRates();
            return Ok(data);
        }
    }
}
