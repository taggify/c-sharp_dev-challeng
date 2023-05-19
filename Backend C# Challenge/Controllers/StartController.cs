using Microsoft.AspNetCore.Mvc;

namespace Backend_C__Challenge.Controllers
{
    public class StartController
    {
        [HttpGet("/hello")]
        public async Task<ActionResult<string>> SayHello(string name) {

            return $"Hi {name}";
        }
    }
}
