using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using mini_bot_api;

namespace mini_bot_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MiniBotController : ControllerBase
    {

        private readonly ILogger<MiniBotController> _logger;

        public MiniBotController(ILogger<MiniBotController> logger)
        {
            _logger = logger;
        }
        [HttpGet("responce/{question}")]
        public ActionResult<MiniBot> Get(string question)
        {
            var responce = new ResponceRecord(question, "");
            return Ok(responce);
        }

        [HttpGet("responce/")]
        public ActionResult<MiniBot> Get()
        {
            var responce = new ResponceRecord("", "");
            return Ok(responce);
        }
    }
}

public record ResponceRecord(string? question, string answer)
{
    MiniBot miniBot = new MiniBot();
    public string answer => miniBot.getAnswer(question);
}

