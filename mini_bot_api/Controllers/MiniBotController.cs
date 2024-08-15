using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using mini_bot_api.Interface;
using mini_bot_api.Model;

namespace mini_bot_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MiniBotController : ControllerBase
    {
        [HttpGet("responce/{question}")]
        public ActionResult<MiniBot> Get([FromServices] IMiniBotService service,  string question)
        {
            try
            {
                Answer q = new Answer("", question);

                Answer answer = service.FindByQuestion(q);
                return Ok(answer);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
            
        }

        [HttpGet("responce/")]
        public ActionResult<MiniBot> Get([FromServices] IMiniBotService service)
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

