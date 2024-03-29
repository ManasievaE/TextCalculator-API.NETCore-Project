﻿using Microsoft.AspNetCore.Mvc;
using System;
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
            try
            {
                return new TextCalculator().Add(input);
            }
            //added after sending the code
            catch (Exception ex)
            {
                return (ex.Message);
            }
        }

    }
}
