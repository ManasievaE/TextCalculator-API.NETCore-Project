using Microsoft.AspNetCore.Mvc;
using TaskOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
