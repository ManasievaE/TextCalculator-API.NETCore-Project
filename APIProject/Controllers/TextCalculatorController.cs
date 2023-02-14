using Microsoft.AspNetCore.Mvc;
using TaskOne;


namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TextCalculatorController : ControllerBase
    {
        [HttpPost]
        public string Calculate(string input)
        {
            return new TextCalculator().Add(input);
        }

    }
}
